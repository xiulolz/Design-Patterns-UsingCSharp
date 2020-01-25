# **開放-封閉原則 (Open-Closed-Principle)**

> _是指軟體實體(類別、模組、函式等等)對於擴展是開放的(**Open for extentions**)，但是對於更改是封閉的(**Closed for modification**)。_

開放-封閉原則是物件導向程式設計的核心，遵循這個原則可以設計出`可維護、可擴展、可複用`的軟體。開發人員應該僅對程式中頻繁出現的那些部分進行抽象，並且拒絕不成熟的抽象。

## 例子

[範例程式碼見 Simple Factory Pattern(原書以 winform 為範例，我自己將其簡化為 ConsoleApp)](https://github.com/xiulolz/Design-Patterns-UsingCSharp/tree/master/SimpleFactory)

以計算機程式為例。最為直覺的寫法就是通通在 client 中寫完所有功能甚至 layout，此時變化並沒有發生。

如果要新增`開根號`的功能呢？
這時就會發現，增加功能就必須修改原本的 client 類別，這就違背了[開放-封閉原則]。

於是考慮重構程式碼，將所有運算抽成`介面`或`抽象類別`，並透過物件導向，降低與 Clinet 之間的耦合。

這樣不但可以滿足需求，還能應對變化。承如剛剛說的新增開根號功能，`只需要新增開根號類別並且實作介面或抽象類別`

---

### 通通在 client 中寫完所有功能甚至 layout

```C#
try
{
    Console.WriteLine("請輸入數字 A");
    string numA = Console.ReadLine().Trim();
    Console.WriteLine("請輸入數字 B");
    string numB = Console.ReadLine().Trim();
    Console.WriteLine("請輸入運算符號+ - \* /");
    string operate = Console.ReadLine().Trim();
    double result = 0.0d;
    switch (operate)
    {
        case "+":
        result = Convert.ToDouble(numA + numB);
        break;
        case "-":
        break;
        // ...以下略
    }
}
catch(Exception e)
{
    Console.WriteLine(e.ToString());
}
```

---

重構程式碼，將所有運算抽成`介面`或`抽象類別`

![開放封閉原則](https://github.com/xiulolz/Design-Patterns-UsingCSharp/blob/master/%E8%A8%AD%E8%A8%88%E6%A8%A1%E5%BC%8F%E5%8E%9F%E5%89%87/%E9%96%8B%E6%94%BE%E5%B0%81%E9%96%89%E5%8E%9F%E5%89%87uml.png)
