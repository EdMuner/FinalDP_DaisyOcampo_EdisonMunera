using MvvmCross.Commands;
using MvvmCross.ViewModels;
using QuadraticEquations.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuadraticEquations.Core.ViewModels
{
    public class QuadraticViewModel : MvxViewModel
    {
        private readonly IQuadraticService _quadraticService;
        private double _a;
        private double _b;
        private double _c;
        private double _resp1;
        private double _resp2;
        private MvxCommand _calculateCommand;



        public QuadraticViewModel(IQuadraticService quadraticService )
        {
            _quadraticService = quadraticService;
        }

        public double A
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }

        public double B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }

        public double C
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }

        public double Resp1
        {
            get => _resp1;
            set => SetProperty(ref _resp1, value);
        }

        public double Resp2
        {
            get => _resp2;
            set => SetProperty(ref _resp2, value);
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            A = 0;
            B = 0;
            C = 0;
            Calculate();
        }

        private void Calculate()
        {
            Resp1 = _quadraticService.GetQuadratic(A, B, C);
            Resp2 = _quadraticService.GetQuadratic2(A, B, C);
        }
    }
}
