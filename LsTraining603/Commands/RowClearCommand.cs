using System;
using System.Windows.Input;

namespace LsTraining603.Commands
{
    public class RowClearCommand : ICommand
    {
        // メンバ変数
        private readonly Action _action;

        // イベント
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal RowClearCommand(Action action)
        {
            this._action = action;
        }

        /// <summary>
        /// ボタンクリック時に呼び出される
        /// </summary>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// CanExecuteがtrueだったら呼び出される
        /// </summary>
        public void Execute(object parameter)
        {
            this._action();
        }
    }
}
