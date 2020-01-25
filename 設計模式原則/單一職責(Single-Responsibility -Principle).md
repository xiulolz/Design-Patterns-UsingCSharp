# **單一職責(Single-Responsibility-Principle)**

_如果一個類別承擔的職責過多，就等於把這些職責耦合在一起，一個職責的變化可能會削弱或者抑制這個類別完成其他職責的能力。這種耦合會導致脆弱的設計，當變化發生時，設計會遭受到意外不到的破壞_

## **例子**

- Modem

  Modem 數據機中有 dial 撥號、handup 掛斷、send 傳送資料跟 recv 接收資料四種方法

  在這個介面中有兩種職責：連接管理(dial、handup)，另一個是資料通訊(send、recv)

  ```C#
  public interface Modem
  {
       public void dial(String phoneNumber);

       public void handup();

       public void send(char c);

       public char recv();
  }
  ```

  這時候就會有**依賴關係發生連鎖**與**修改時造成很多地方出現 BUG 的脆弱性**

  **這時就可以將兩個職責(連接管理、資料通訊)拆開**

  ![UML](https://github.com/xiulolz/Design-Patterns-UsingCSharp/blob/master/%E8%A8%AD%E8%A8%88%E6%A8%A1%E5%BC%8F%E5%8E%9F%E5%89%87/uml.png)
