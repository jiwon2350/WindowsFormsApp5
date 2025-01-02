using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private static int[] sharedArray;

        public Form1()
        {
            InitializeComponent();

            sharedArray = new int[5];
        }
        

        private void ArraywithRef(ref int[] array)//ref 사용 
        {
            for (int i = 0; i < sharedArray.Length; i++)
                sharedArray[i] = i + 1;
        }

        private void ArraywithOut(out int[] array, int size)//out 사용
        {
            array = new int[size];
            for (int i=0;i<size; i++)
            {
                array[i] = i + 1;
            }
        }

        // 테스트 메서드 (ref와 out 호출 및 결과 출력)
        private void TestArrayMethods()
        {
            // 1. ref 사용
            ArraywithRef(ref sharedArray); // sharedArray를 ref로 전달
            MessageBox.Show("Ref 결과: " + string.Join(", ", sharedArray));

            // 2. out 사용
            ArraywithOut(out sharedArray, 7); // 크기 7의 새 배열 생성
            MessageBox.Show("Out 결과: " + string.Join(", ", sharedArray));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestArrayMethods();
        }
    }
}
