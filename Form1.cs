using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using 操作;
using 链栈的节点;


namespace Calculator_by_Stack
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        #region UI设计
        //关闭程序按钮
        private void Close_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
        //实现渐变动画
        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.3)
                this.Opacity -= 0.3;
            else
            {
                timer.Stop();
                this.Close();
            }
        }
        //实现无边框窗口拖动
        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int HTCAPTION = 2;
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)  // 按下的是鼠标左键              
            {
                ReleaseCapture();   // 释放捕获                 
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);    // 拖动窗体              
            }
        }



        #endregion UI设计结束

        #region 按钮功能实现
        public void btn_1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)//判断输入框是否包含汉字，是否是0，以下都相同
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "1";//显示1
            numDisplay.Text += "1";//显示1
            if (numDisplay.Text.Contains("=") == true)//有括号的话就要运算了，以下都相同
            {
                numDisplay.Text = txtDisplay.Text;
            }

        }
     
                private void btn_2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "2";
            numDisplay.Text += "2";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "3";
            numDisplay.Text += "3";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "4";
            numDisplay.Text += "4";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "5";
            numDisplay.Text += "5";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "6";
            numDisplay.Text += "6";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "7";
            numDisplay.Text += "7";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "8";
            numDisplay.Text += "8";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "9";
            numDisplay.Text += "9";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "0";
            numDisplay.Text += "0";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }
        }
        //左括号
        private void btn_brack_left_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "(";
            numDisplay.Text += "(";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }
        }
        //右括号
        private void btn_brack_right_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += ")";
            numDisplay.Text += ")";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }
        }
        //点号
        private void btn_spot_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {

                txtDisplay.Text = "";
            }
            txtDisplay.Text += ".";
            numDisplay.Text += ".";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }
        }
        //加号
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                numDisplay.Text = "=0";
            }

            txtDisplay.Text += "+";
            numDisplay.Text += "+";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }

        }
        //减号
        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                numDisplay.Text = "=0";
            }

            txtDisplay.Text += "-";
            numDisplay.Text += "-";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }

        }
        //乘号
        private void btn_time_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0"|| Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]") == true)
            {
                numDisplay.Text = "=0";
            }

            txtDisplay.Text += "*";
            numDisplay.Text += "×";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }

        }
        //除号
        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                numDisplay.Text = "=0";
            }

                txtDisplay.Text += "/";
                numDisplay.Text += "÷";
            if (numDisplay.Text.Contains("=") == true)
            {
                numDisplay.Text = txtDisplay.Text;
            }



        }
        //等于号
        private void btn_equal_Click(object sender, EventArgs e)
        {
            // 判断表达式是否合法
            if (txtDisplay.Text == "0" && numDisplay.Text.Contains("=") == false)
            {
                numDisplay.Text = "=0";

            }
            else if (txtDisplay.Text.Contains("%") == true)
            {
                numDisplay.Text = "";
                txtDisplay.Text = "表达式错误";
            }
            else if (Check.check(txtDisplay.Text) == false|| Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
                {
                txtDisplay.Text = "表达式错误";
                numDisplay.Text = "";
            }
            //如果第一个输入元素真的是-,需要在表达式前加0
           else if (txtDisplay.Text.StartsWith("-") && numDisplay.Text.Contains("=") == false)
            {
                numDisplay.Text += "=";
                String s = "0"+txtDisplay.Text + "#";
                txtDisplay.Text = Calu.BackPoland(s);
            }
           else if (txtDisplay.Text != "0" && numDisplay.Text.Contains("=") == false)
            {
                numDisplay.Text += "=";
                String s = txtDisplay.Text + "#";
                //s.Replace("÷", "/"); 
                //s.Replace("×", "*");
                txtDisplay.Text = Calu.BackPoland(s);
            }
            //如果第一个输入元素真的是0
           



        }

        //退格按钮
        private void btn_back_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length != 0)//如果有字符的话
            {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1); ;

                if (txtDisplay.Text == "")//如果字符都没了，直接复原
                {
                    txtDisplay.Text += "0";
                    numDisplay.Text = "";
                }

            }
    
               
        }

        //CE按钮
        private void btn_clear_Click(object sender, EventArgs e)
        {
            // 有汉字或者是字符长度不为0，就复原
            if (numDisplay.Text.Length != 0 || numDisplay.Text == "∞" || Regex.IsMatch(txtDisplay.Text, "[\u4e00-\u9fbb]")==true)
            {
                numDisplay.Text = "";
                txtDisplay.Text = "0";
               
            }

        }
        //二进制转换
        private void btn_binary_Click(object sender, EventArgs e)
        {
            while (Regex.IsMatch(numDisplay.Text, @"^[0-9]*$") == true && numDisplay.Text != "")
            {
                string w = Transfer.format(long.Parse(numDisplay.Text), 2);//转换为2进制的数
                int number = (((w.Length) + 4 - 1) & ~(4 - 1));//向上取4的倍数
                txtDisplay.Text = w.PadLeft(number, '0').Insert(4, " "); ;   //补零并显示,间隔4位加空格
                break;
            }
            while (Regex.IsMatch(txtDisplay.Text, @"^[0-9]*$") == true && txtDisplay.Text != "")
            {
                string w = Transfer.format(long.Parse(txtDisplay.Text), 2);//转换为2进制的数
                int number = (((w.Length) + 4 - 1) & ~(4 - 1));//向上取4的倍数
                txtDisplay.Text = w.PadLeft(number, '0').Insert(4, " "); ;   //补零并显示,间隔4位加空格
                break;
            }
        }
        //八进制转换
        private void btn_octonary_Click(object sender, EventArgs e)
        {
            while (Regex.IsMatch(numDisplay.Text, @"^[0-9]*$") == true&& numDisplay.Text != "")
            {
                string w = Transfer.format(long.Parse(numDisplay.Text), 8);//转换为8进制的数
                txtDisplay.Text = w;
                break;
            }
            while (Regex.IsMatch(txtDisplay.Text, @"^[0-9]*$") == true && txtDisplay.Text != "")
            {
                string w = Transfer.format(long.Parse(txtDisplay.Text), 8);//转换为8进制的数
                txtDisplay.Text = w;
                break;
            }
        }
        //十六进制转换
        private void btn_hexa_Click(object sender, EventArgs e)
        {
            while (Regex.IsMatch(numDisplay.Text, @"^[0-9]*$")==true && numDisplay.Text != "")
            {
                string w = Transfer.format(long.Parse(numDisplay.Text), 16);//转换为16进制的数
                txtDisplay.Text = w;
                break;
            }
            while (Regex.IsMatch(txtDisplay.Text, @"^[0-9]*$") == true && txtDisplay.Text != "")
            {
                string w = Transfer.format(long.Parse(txtDisplay.Text), 16);//转换为16进制的数
                txtDisplay.Text = w;
                break;
            }
        }
        //百分数
        private void button4_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtDisplay.Text, @"^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$")|| Regex.IsMatch(txtDisplay.Text, @"^[0-9]*$"))
            {
                txtDisplay.Text = (Convert.ToDouble(txtDisplay.Text) * 100).ToString();
                txtDisplay.Text += "%";
                numDisplay.Text = txtDisplay.Text;
            }
            else
            {
                txtDisplay.Text = "表达式错误";
                numDisplay.Text = "";
            }
        }
        //倒数
        private void btn_backwards_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtDisplay.Text, @"^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$")|| Regex.IsMatch(txtDisplay.Text, @"^[0-9]*$"))
            {
                txtDisplay.Text = (1/Convert.ToDouble(txtDisplay.Text)).ToString();
                numDisplay.Text = txtDisplay.Text;
            }
            else
            {
                txtDisplay.Text = "表达式错误";
                numDisplay.Text = "";
            }
        }
    
        //平方
        private void btn_square_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtDisplay.Text, @"^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$")|| Regex.IsMatch(txtDisplay.Text, @"^[0-9]*$"))
            {
                txtDisplay.Text = ( Convert.ToDouble(txtDisplay.Text)* Convert.ToDouble(txtDisplay.Text)).ToString();
                numDisplay.Text = txtDisplay.Text;
            }
            else
            {
                txtDisplay.Text = "表达式错误";
                numDisplay.Text = "";
            }

        }
        //二次根号
        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtDisplay.Text, @"^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$") || Regex.IsMatch(txtDisplay.Text, @"^[0-9]*$"))
            {
                txtDisplay.Text = (Math.Sqrt(Convert.ToDouble(txtDisplay.Text))).ToString();
                numDisplay.Text = txtDisplay.Text;
            }
            else
            {
                txtDisplay.Text = "表达式错误";
                numDisplay.Text = "";
            }
        }

       
        #endregion

        #region 键盘功能映射

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
        //首先屏蔽空格键默认设置
        if (e.KeyCode == Keys.Space)
        {
            e.Handled = true;//表示已经处理了键盘消息
        }
        switch (e.KeyCode)
            {//点到哪个就调用哪个
                case Keys.D0:
                    btn_0_Click(null, null);
                    break;
                case Keys.D1:
                    btn_1_Click(null, null);
                    break;
                case Keys.D2:
                    btn_2_Click(null, null);
                    break;
                case Keys.D3:
                    btn_3_Click(null, null);
                    break;
                case Keys.D4:
                    btn_4_Click(null, null);
                    break;
                case Keys.D5:
                    btn_5_Click(null, null);
                    break;
                case Keys.D6:
                    btn_6_Click(null, null);
                    break;
                case Keys.D7:
                    btn_7_Click(null, null);
                    break;
                case Keys.D8:
                    btn_8_Click(null, null);
                    break;
                case Keys.D9:
                    btn_9_Click(null, null);
                    break;

                case System.Windows.Forms.Keys.Add:
                    btn_add_Click(null, null);
                    break;
                case System.Windows.Forms.Keys.Subtract:
                    btn_minus_Click(null, null);
                    break;
                case System.Windows.Forms.Keys.Multiply:
                    btn_time_Click(null, null);
                    break;
                case System.Windows.Forms.Keys.Divide:
                    btn_divide_Click(null, null);
                    break;
                case System.Windows.Forms.Keys.Space:
                    btn_equal_Click(null, null);
                    break;
                case System.Windows.Forms.Keys.Back:
                    btn_back_Click(null, null);
                    break;
            }
        }


        #endregion


    }
}

namespace 链栈的节点
{

    class LinkNode<T>
    {
        private T data;//存储数据
        private LinkNode<T> next;//指向下一节点
        public LinkNode()
        {
            data = default(T);
            next = null;
        }
        public LinkNode(T data)
        {
            this.data = data;
            next = null;
        }
        public LinkNode(T data, LinkNode<T> next)
        {
            this.data = data;
            this.next = next;
        }
        public LinkNode(LinkNode<T> next)
        {
            this.next = next;
            data = default(T);
        }
        public T Data { get { return data; } set { data = value; } }
        public LinkNode<T> Next { get { return next; } set { next = value; } }

    }
}


namespace 链栈的接口
{
    //数序栈
    interface LinkStack<T>
    {
        int Count { get; }//元素个数（属性）
        int GetLenth();//栈的长度（方法）
        bool IsEmpty();//栈是否为空
        void Clear();//清空栈
        void Push(T item);//入栈
        T Pop();//出栈
        T Peek();//取得栈顶元素
    }
}


namespace 链栈
{
    class LinkStack<T> : 链栈的接口.LinkStack<T>
    {
        private LinkNode<T> top;//栈顶元素节点
        private int count = 0;//记录栈的元素个数

        public int Count
        {
            get { return count; }
        }
        public int GetLenth()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Clear()
        {
            count = 0;
            top = null;
        }

        public void Push(T item)
        {
            //栈顶元素
            LinkNode<T> newNode = new LinkNode<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;

        }

        public T Pop()
        {
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        public T Peek()
        {
            return top.Data;
        }
    }
}

namespace 操作
{
    // 运算
    public class Calu
    {
        // 判断是否是数字
        static bool IsNumber(string s)
        {
            return Regex.IsMatch(s, @"\d+"); //正则表达式判断
        }
        //判断是不是运算符
        static bool IsSiZe(string s)
        {
            string ts = "+-*/";//正则表达式判断
            return ts.IndexOf(s) > -1;
        }
        //运算符优先级别判断
        static int Level(string s)
        {
            int i = 0;
            switch (s)
            {
                case ",":
                    i = 0;
                    break;
                case "(":
                case ")":
                case "#":
                    i = 1;
                    break;
                case "+":
                case "-":
                    i = 2;
                    break;
                case "*":
                case "/":
                    i = 3;
                    break;
            }
            return i;
        }
        //计算函数
            private static void Calc(链栈的接口.LinkStack<string> numStack, 链栈的接口.LinkStack<string> operStack)
            {
                float rightnum = float.Parse(numStack.Pop());
                float leftnum = float.Parse(numStack.Pop());
                string oper = operStack.Pop();
                switch (oper)
                {
                    case "+":
                        numStack.Push((leftnum + rightnum).ToString());
                        break;
                    case "-":
                        numStack.Push((leftnum - rightnum).ToString());
                        break;
                    case "*":
                        numStack.Push((leftnum * rightnum).ToString());
                        break;
                    case "/":
                        numStack.Push((leftnum / rightnum).ToString());
                        break;
                }

            }
        //总体调用函数
        internal static string BackPoland(string expression)
        {
            链栈的接口.LinkStack<string> operStack = new 链栈.LinkStack<string>();
            链栈的接口.LinkStack<string> numStack = new 链栈.LinkStack<string>();

            operStack.Push("#");  //进栈  便于比较

            string token = "";
            for (int i = 0; i < expression.Length; i++)
            {
                if (IsNumber(expression[i].ToString())|| expression[i].ToString()==".")  //如果是数字
                {
                    token += expression[i].ToString();
                }
                else if (expression[i].ToString() == "(")   //左括号直接进栈
                {
                    operStack.Push(expression[i].ToString());
                    if (IsNumber(token))
                        numStack.Push(token);
                    token = "";
                }
                else if (IsSiZe(expression[i].ToString()))
                {
                    if (IsNumber(token))
                        numStack.Push(token);
                    token = "";
                    int item = Level(expression[i].ToString()).CompareTo(Level(operStack.Peek()));  //比较运算符优先级
                    if (item > 0)                   //如果优先级高于栈顶，运算符进栈
                    {
                        operStack.Push(expression[i].ToString());
                    }
                    else                            //如果运算符小于或等于栈顶  进行计算 并将运算符进栈
                    {

                        Calc(numStack, operStack);

                        operStack.Push(expression[i].ToString());
                    }

                }
                else if (expression[i].ToString() == ")")  //如果遇到右括号 依次遍历进行计算直至遇到左括号
                {
                    if (IsNumber(token))
                        numStack.Push(token);
                    token = "";
                    while (operStack.Peek() != "(")
                    {
                        Calc(numStack, operStack);
                    }
                    token = numStack.Pop();  //拿出数字便于进行下一次计算
                    operStack.Pop();  //符合条件的左括号出栈

                }
                else  //遍历结束
                {
                    if (IsNumber(token))
                        numStack.Push(token);
                    token = "";
                    while (numStack.Count > 1)
                    {
                        Calc(numStack, operStack);
                    }
                }
            }
            return numStack.Pop();
        }


    }
    //检查表达式
    public class Check
    {
        public static bool check(string str)
        {
            if (str.Equals(""))
            {
                return false;
            }
            if (str == ".")
            {

                return false;
            }
            //如果有连续的符号的话返回false
            if (Regex.IsMatch(str, @"[+-/\\*]{2,}"))
            {

                return false;
            }

            //如果出现连续的括号的话返回false
            if (Regex.IsMatch(str, @"[\(\)]{2,}"))
            {
                return false;
            }

            //如果左括号后面出现+*/符号的时候返回false
            if (Regex.IsMatch(str, @"\([+/\\*]+"))
            {
                return false;
            }

            //如果右括号后面出现数字或者没有出现+-*/的时候返回false
            if (Regex.IsMatch(str, @"\)[^+-/\\*]"))
            {
                return false;
            }

            //如果左括号前面没有出现+-*/的时候返回false
            if (Regex.IsMatch(str, @"[^+-/\\*]+\("))
            {
                return false;
            }

            //如果右括号前面出现+-*/的时候返回fasle
            if (Regex.IsMatch(str, @"[+-/\\*]+\)"))
            {
                return false;
            }

            //递归检查括号是否成对出现
            char item;
            链栈的接口.LinkStack<string> s = new 链栈.LinkStack<string>();
            for (int i = 0; i < str.Length; i++)
            {
                item = str[i];
                if (item == '(')
                {
                    s.Push("(");
                }
                else if (item == ')')
                {
                    if (s.Count > 0)
                    {
                        s.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (s.Count != 0)
            {
                return false;
            }
            return true;
        }
    }

    //进制转换函数
    public class Transfer
    {
        public static String format(long number, long n)
        {
            链栈的接口.LinkStack<string> s = new 链栈.LinkStack<string>();
            String data = "0123456789ABCDEF";
            while (number > 0)
            {
                int remainder = (int)(number % n);
                string x = data[remainder].ToString();
                s.Push(x);
                number /= n;
            }
            string result = "";

            while (s.Count > 0)
            {
                result += s.Pop();
            }
            return result;
        }
    }
}

