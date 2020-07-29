using System;
using System.Collections.ObjectModel;
using LsTraining603.BasePages;
using LsTraining603.Models;
using LsTraining603.Commands;
using System.Windows.Input;

namespace LsTraining603.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainViewModel()
        {
            // リストにバインドする要素の指定
            Items = new ObservableCollection<MemoItem>();

            // 追加ボタンのコマンド割り当て
            AddRowCommand = new AddRowCommand(ListAddRow);

            // クリアボタンのコマンド割り当て
            RowClearCommand = new RowClearCommand(ListClearRow);

        }

        /// <summary>
        /// リストアイテム
        /// </summary>
        public ObservableCollection<MemoItem> Items { get; set; }

        /// <summary>
        /// 追加ボタンコマンド
        /// </summary>
        public ICommand AddRowCommand { get; }

        /// <summary>
        /// クリアボタンコマンド
        /// </summary>
        public ICommand RowClearCommand { get; }

        /// <summary>
        /// 行追加処理
        /// </summary>
        private void ListAddRow()
        {
            // データの投入
            Items.Add(new MemoItem { Text = (Items.Count + 1).ToString() + " 行目", Description = "追加しました" });
        }

        /// <summary>
        /// 行クリア処理
        /// </summary>
        private void ListClearRow()
        {
            // データの初期化
            Items.Clear();
        }
    }

}
