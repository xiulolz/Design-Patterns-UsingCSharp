using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StrategyPattern.Context;
using StrategyPattern.Interface.Extends;
using StrategyPattern.Interface;


namespace StrategyPattern
{
    public partial class Main : Form
    {
        /// <summary>
        /// 情境：商場收銀軟體
        /// 1. simple factory pattern實作
        /// 2. strategy pattern實作
        /// 3. strategy+simple factory
        /// </summary>
        public Main()
        {
            InitializeComponent();
            CenterToScreen();
            var cashTypeArray = Enum.GetValues(typeof(CashType)).Cast<Enum>().ToArray();
            comboBox1.Items.AddRange(cashTypeArray);
        }

        private CashContext fCashContext;

        /// <summary>
        /// [Strategy Pattern]：定義了演算法家族，並分別封裝，讓他們之間可以互相替換。此模式讓演算法的變化不會影響到使用演算法的客戶
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // 原始策略模式
            double totalPrice = 0.0d;
            double total = 0.0d;
            fCashContext = comboBox1.SelectedItem.ToString() switch
            {
                "Normal" => new CashContext(new CashNormal()),
                "Rebate" => new CashContext(new CashRebate(0.8)),
                "Return" => new CashContext(new CashReturn(300, 100)),
                _ => throw new Exception("不知名的外星人")
            };
            totalPrice = fCashContext.GetResult(100);
            total += totalPrice;
            MessageBox.Show(total.ToString());

            // strategy + factory
            fCashContext = new CashContext(comboBox1.SelectedItem.ToString(), 0.8, 300, 100);
            totalPrice = fCashContext.GetResult(100);

            // 簡單工廠用法
            // ICash cash = CashFactory.CreateCashFactory(CashType.Normal);
            // ... = cash.GetResult(...);

            // 策略+簡單工廠
            // fCashContext = new CashContext(comboBox1.SelectedItem.ToString(), 0.8, 300, 100);
            // ... = fCashContext.GetResult(...);

            // 只使用 [simple factory pattern] client端必須知道 ICash 和 CashFactory
            // 而 [ Strategy Pattern ] 只需認識CashContext，其餘動作皆封裝起來，"耦合性更加降低"。

            // 策略模式的優點是簡化了unit test，因為每個演算法都有屬於自己的類別，可以透過自己的介面進行單獨測試
            // (修改任一其中演算法並不會影響其他演算法)

            // 總結：[策略模式] 就是用來封裝演算法的，只要在分析過程中聽到需要在不同時間使用不同演算法就可以考慮使用策略模式處理這種變化的可能性

            // 當不同行為堆砌在同類別就很難避免使用條件敘述來選擇合適的行為。
            // 將這些行為封裝在一個個獨立的Strategy類別中，可以在使用這些行為中的類別消除條件敘述
            // 以這個商場收銀為例子 (Client 最終消除了條件敘述 只需要輸入設定檔(type、滿額折扣、打折)參數就可以避免大量判斷
            // 也就是說 [ 策略模式封裝了變化 ]。
            // 而結合使用了策略+簡單工廠這兩種patterns後大大減輕了Client端的負擔。

            // 網路上找到的解釋 個人認為蠻好理解的↓
            // 簡單工廠模式是用來建立物件的模式，關注物件如何被產生
            // 策略模式是一種行為模式，關注的是行為的封裝
        }
    }
}
