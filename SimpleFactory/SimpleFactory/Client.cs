using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    
    public class Client
    {
        static void Main(string[] args)
        {
            // 情境：當我有一個計算機程式 該如何以物件導向寫出來?
            /*
             * 1. 每次都會有兩個數字需要計算
             * 2. 有運算元 [+、-、*、/]
             * 3. 根據不同運算元產生實體，原本為一整個class進行switch，但是這樣耦合性過高，所以拆分成4個class將相同事情封裝到介面再個別實現
             * 4. 讓運算類別關聯簡單工廠類別，若以後需要增加需求只需要到工廠類別進行修改，使用者只需要創建實體並不需要理會內部怎麼操作。
             * 
             */

            // 優點： 使用者不需要明確知道怎麼創建，只需要call CreateXXX()，甚至可以配合組態檔參數進行設定
            // 缺點： 當 Facotry 需要增加新的 Product 時，必然需要對 Factory 的程式碼進行變更。

            Operation op = OperationFactory.CreateOperate(Operater.Add);
            op.Number1 = 1;
            op.Number2 = 2;
            var result = op.GetResult();
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
