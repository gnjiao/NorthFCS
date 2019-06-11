﻿using BFM.WPF.SHWMS.Service;
using BFM.WPF.SHWMS.ViewModel;
using BFM.WPF.SHWMS.ViewModel.Finger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BFM.WPF.SHWMS
{
    /// <summary>
    /// FingerGraphic.xaml 的交互逻辑
    /// </summary>
    public partial class FingerGraphic : Page
    {
        FingerJobViewModel mainJobViewModel;
        JobService<FingerOrderViewModel> jobService;
        private CancellationTokenSource token;
        private CancellationTokenSource printToken;
        public FingerGraphic()
        {
            InitializeComponent();
            mainJobViewModel = new FingerJobViewModel();
            jobService = new JobService<FingerOrderViewModel>(mainJobViewModel);
            jobService.TaskJobFinishEvent += JobService_TaskJobFinishEvent;
            jobService.StartMachiningCountEvent += (s) => { s.VMOne.StartMachiningCount(); s.LatheTwo.StartMachiningCount(); };
            jobService.StopMachiningCountEvent += (s) => { s.VMOne.StopMachiningCount(); s.LatheTwo.StopMachiningCount(); };

            this.Loaded += FingerGraphic_Loaded;
            mainJobViewModel.StartJobEvent += MainJobViewModel_StartJobEvent;
            mainJobViewModel.JobOperationEvent += MainJobViewModel_JobOperationEvent;
            mainJobViewModel.MachineResetEvent += MainJobViewModel_MachineResetEvent;
        }

        private void MainJobViewModel_MachineResetEvent()
        {

            Task.Factory.StartNew(() =>
            {
                var state = jobService.GetJobState();
                if (!state)
                {
                    Dispatcher.BeginInvoke(new Action(() => MessageBox.Show("请先清空产线任务列表")));
                    return;
                }
                jobService.SendJobTaskFinish();
            });

        }

        private void JobService_TaskJobFinishEvent(string obj)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                btnCycle.IsEnabled = true;

            }));

        }

        private void MainJobViewModel_JobOperationEvent(JobWorkEnum arg1, string arg2)
        {
            infoLabel.Content = arg2;
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.AutoReset = false;
            timer.Enabled = true;
            timer.Interval = 2000;
            timer.Elapsed += (s, e) => { Dispatcher.BeginInvoke(new Action(() => infoLabel.Content = "")); };
            timer.Start();
        }

        private void MainJobViewModel_StartJobEvent(FingerOrderViewModel obj)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                btnCycle.IsEnabled = false;
                btnCancel.IsEnabled = true;
                btnStopCycle.IsEnabled = true;

            }));
            token = new CancellationTokenSource();
            printToken = new CancellationTokenSource();
            Task.Factory.StartNew(() => jobService.Start(token), token.Token);
            Task.Factory.StartNew(() => jobService.StartPrint(printToken), printToken.Token);
        }

        private void FingerGraphic_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = mainJobViewModel;
            btnStopCycle.IsEnabled = false;
            btnCancel.IsEnabled = false;
        }

        private void BtnStopCycle_Click(object sender, RoutedEventArgs e)
        {
            btnStopCycle.IsEnabled = false;
            jobService.IsCycleStop = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("确定所有订单任务吗？", "订单取消", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                btnCancel.IsEnabled = false;
                btnStopCycle.IsEnabled = false;
                token.Cancel();
                printToken.Cancel();
            }

        }

    }
}
