using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowform_day2_example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //책 항목 추가하기
            cb_books.Items.Add("IT 도서");
            cb_books.Items.Add("역사 도서");
            cb_books.Items.Add("예술 도서");

            //나이 항목 추가
            cb_age.Items.Add("10대 이하");
            cb_age.Items.Add("20대");
            cb_age.Items.Add("30대");
            cb_age.Items.Add("40대");
            cb_age.Items.Add("50대");
            cb_age.Items.Add("60대 이상");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void b_fr_Click(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 출력 테스트용
            //  MessageBox.Show("결제 수단 : " + " " + "\n할부 종류 : " + lb_book.Text, "결제 확인");
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //항목 선택시 누적되지 않게 초기화
            lb_book.Items.Clear();

            //it도서 -> 프로그래밍, ai, iot 도서별 세부 분류
            string[] lst4 = { "C#", "java", "python" };
            string[] lst5 = { "Orange 데이터 마이닝", "OpeCV", "deep learing" };
            string[] lst6 = { "라즈베리파이", "젝슨나노", "아두이노" };

            //역사도서 -> 한국사, 세계사, 고대그리스 도서별 세부분류
            string[] lst7 = { "삼국시대와 통일신라", "조선의 건국과 발전", "근.현대의 사회" };
            string[] lst8 = { "고대 사회의 발전", "중세 사회로 전환", "근대 사회의 태동" };
            string[] lst9 = { "그리스 로마신화", "그리스 철학", "그리스 과학" };

            //예술도서 -> 체육, 음악, 미술 도서별 세부분류
            string[] lst10 = { "체육/스포치 이론", "취미/실용/스포츠", "운동하는 아이가 행복하다" };
            string[] lst11 = { "오케스트라 좋아하세요?", "음악의 비밀", "꿈을 찾는 음대생" };
            string[] lst12 = { "미술 과학을 탐하다", "서양 미술사", "방구석 미술관" };

            // lb_kinds에서 선택된 항목을 str형태로 저장
            string curItem = lb_kinds.SelectedItem.ToString();

            // 선택된 항목의 인덱스 찾기 ==여기선 안씀
            int index = lb_book.FindString(curItem);

            // kinds과 문자를 비교해서 lb항목 출력
            if (curItem == "프로그래밍 도서") lb_book.Items.AddRange(lst4);
            else if (curItem == "AI 도서") lb_book.Items.AddRange(lst5);
            else if (curItem == "iot 도서") lb_book.Items.AddRange(lst6);
            else if (curItem == "한국사") lb_book.Items.AddRange(lst7);
            else if (curItem == "세계사") lb_book.Items.AddRange(lst8);
            else if (curItem == "고대그리스") lb_book.Items.AddRange(lst9);
            else if (curItem == "체육") lb_book.Items.AddRange(lst10);
            else if (curItem == "음악") lb_book.Items.AddRange(lst11);
            else if (curItem == "미술") lb_book.Items.AddRange(lst12);


        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void cb_books_SelectedIndexChanged(object sender, EventArgs e)
        {

            lb_kinds.Items.Clear();
            // 첫번째 분류
            string[] lst1 = { "프로그래밍 도서", "AI 도서", "iot 도서" };
            string[] lst2 = { "한국사", "세계사", "고대그리스" };
            string[] lst3 = { "체육", "음악", "미술" };


            if (cb_books.SelectedIndex == 0) { lb_kinds.Items.AddRange(lst1); }
            else if (cb_books.SelectedIndex == 1) lb_kinds.Items.AddRange(lst2);
            else if (cb_books.SelectedIndex == 2) lb_kinds.Items.AddRange(lst3);

        }
        private void cb_age_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void b_enter_Click(object sender, EventArgs e)
        {

            string sex = "";

            //성별 확인
            if (radioButton1.Checked) { sex = "남성"; }
            else if (radioButton2.Checked) { sex = "여성"; }
            else { MessageBox.Show("성별을 체크하세요", "성별 확인"); }


            //현재 날짜를 대여일로 선언
            tb_borrowdate.Text = DateTime.Now.ToString("yyyy/MM/dd").Substring(0, 4) + "/"
                     + DateTime.Now.ToString("yyyy/MM/dd").Substring(5, 2) + "/"
                     + DateTime.Now.ToString("yyyy/MM/dd").Substring(8, 2);   // 날짜 표시 

            //기본 7일 뒤 반납
            tb_rerturndate.Text = DateTime.Now.ToString("yyyy/MM/dd").Substring(0, 4) + "/"
                    + DateTime.Now.ToString("yyyy/MM/dd").Substring(5, 2) + "/"
                    + DateTime.Now.AddDays(+7).ToString("yyyy/MM/dd").Substring(8, 2);   // addDays가 날짜를 기준으로 연산을해줌



            //공백 예외처리 (아이디, 이름, 전화번호, 소속, 성별, 대여책)
            if (tb_id.Text == "" || 
                tb_group.Text == "" || 
                tb_name.Text == "" || 
                tb_phone.Text == "" || 
                cb_age.Text == "" || 
                lb_book.Text == "")
            {
                MessageBox.Show("내용을 입력하세요");
            }
            else
            { //데이터 추가형식 '배열'
                string[] slist = new string[] { tb_id.Text, tb_name.Text, cb_age.Text, 
                    sex, tb_phone.Text, tb_group.Text, tb_borrowdate.Text, 
                    tb_rerturndate.Text, lb_book.Text };
                //배열 -> 리스트 항목형식으로 변경
                ListViewItem viewItem = new ListViewItem(slist);
                listView1.Items.Add(viewItem);



                //업데이트 후 항목 초기화

                //텍스트 초기화
                tb_phone.Clear();
                tb_id.Clear();
                tb_group.Clear();
                tb_name.Clear();
                tb_borrowdate.Clear();
                tb_rerturndate.Clear();

                //항목 초기화
                lb_book.Items.Clear();

                //인덱스는 -1이 초기화  // 0-> 해당인덱스가 default가 됨.
                cb_age.SelectedIndex = -1;
                cb_books.SelectedIndex = -1;

                //라디오 버튼 초기화
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }

        }
        private void tb_borrowdate_TextChanged(object sender, EventArgs e)
        {


        }
        private void button2_Click(object sender, EventArgs e)
        {
            //선택된 항목이 있을경우 
            if (listView1.Items.Count != 0)
            {
                listView1.FocusedItem.Remove();      //선택 된 항목 삭제
            }
            else
            {
                MessageBox.Show("지울게 없습니다."); //예외처리
            }
        }
    }
}
