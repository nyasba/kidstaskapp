using System;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KidsTaskApp.item
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KidsTaskMorning : ContentPage
    {
        bool[] taskDone = new bool[] { false, false, false, false, false, false, false, false, false };

        public KidsTaskMorning()
        {
            InitializeComponent();
            Resources["taskButton1"] = Resources["taskButtonNotDone"];
            Resources["taskButton2"] = Resources["taskButtonNotDone"];
            Resources["taskButton3"] = Resources["taskButtonNotDone"];
            Resources["taskButton4"] = Resources["taskButtonNotDone"];
            Resources["taskButton5"] = Resources["taskButtonNotDone"];
            Resources["taskButton6"] = Resources["taskButtonNotDone"];
            Resources["taskButton7"] = Resources["taskButtonNotDone"];
            Resources["taskButton8"] = Resources["taskButtonNotDone"];
            Resources["taskButton9"] = Resources["taskButtonNotDone"];
            taskButton1.Clicked += TaskButton1_Clicked;
            taskButton2.Clicked += TaskButton2_Clicked;
            taskButton3.Clicked += TaskButton3_Clicked;
            taskButton4.Clicked += TaskButton4_Clicked;
            taskButton5.Clicked += TaskButton5_Clicked;
            taskButton6.Clicked += TaskButton6_Clicked;
            taskButton7.Clicked += TaskButton7_Clicked;
            taskButton8.Clicked += TaskButton8_Clicked;
            taskButton9.Clicked += TaskButton9_Clicked;
        }

        private void TaskButton1_Clicked(object sender, EventArgs e)
        {
            TaskButtonClicked(1);
            TaskButtonAllDoneCheck();
        }

        private void TaskButton2_Clicked(object sender, EventArgs e)
        {
            TaskButtonClicked(2);
            TaskButtonAllDoneCheck();
        }

        private void TaskButton3_Clicked(object sender, EventArgs e)
        {
            TaskButtonClicked(3);
            TaskButtonAllDoneCheck();
        }

        private void TaskButton4_Clicked(object sender, EventArgs e)
        {
            TaskButtonClicked(4);
            TaskButtonAllDoneCheck();
        }

        private void TaskButton5_Clicked(object sender, EventArgs e)
        {
            TaskButtonClicked(5);
            TaskButtonAllDoneCheck();
        }

        private void TaskButton6_Clicked(object sender, EventArgs e)
        {
            TaskButtonClicked(6);
            TaskButtonAllDoneCheck();
        }

        private void TaskButton7_Clicked(object sender, EventArgs e)
        {
            TaskButtonClicked(7);
            TaskButtonAllDoneCheck();
        }

        private void TaskButton8_Clicked(object sender, EventArgs e)
        {
            TaskButtonClicked(8);
            TaskButtonAllDoneCheck();
        }

        private void TaskButton9_Clicked(object sender, EventArgs e)
        {
            TaskButtonClicked(9);
            TaskButtonAllDoneCheck();
        }

        private void TaskButtonClicked(int taskNumber)
        {
            if (taskDone[taskNumber-1])
            {
                Resources["taskButton" + taskNumber.ToString()] = Resources["taskButtonNotDone"];
                taskDone[taskNumber-1] = false;
            }
            else
            {
                Resources["taskButton" + taskNumber.ToString()] = Resources["taskButtonDone"];
                taskDone[taskNumber - 1] = true;
            }
        }

        private void TaskButtonAllDoneCheck()
        {
            if (!taskDone.Contains(false))
            {
                DisplayAlert("おしらせ", "レベルアップ！", "OK");
            }
        }
    }
}