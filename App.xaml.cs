using System.Configuration;
using System.Data;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NavigationViewExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string Run_Time_Path = $"{Environment.CurrentDirectory}" + "\\AppD";
        public static string setting_path = $"{Environment.CurrentDirectory}" + "\\AppD\\setting.txt";//其他窗口也用这个
        public static string InterfaceLanguage_All = "";//其实是选择的语言文本的所有
        public static string settings_ = "";
        public static List<string> setting_all_list = App.settings_.Split("${@}").ToList();
        public static List<string> IL_all_list = App.settings_.Split("${@}").ToList();
        public static string Mediaworkfile = "";
        public static string Temp_Lrc_txt ="";//放到LRC。xaml获取歌词的
        public static string Acceleration_Mode = "";
        public static string Choose_Fast_Mod = "";//CUDA，OPENCL，未写完
        public static string Cover_of_the_List_Path= $"{Environment.CurrentDirectory}" + "\\User_Media\\Cover_of_the_List_${@}.txt";//列表,让mainwindow加载时读取
        public static List<string> Cover_of_the_List = new List<string>();//列表的列表_乐
        public static int V_Slider =0;//slider的位置
        public static string music = "";//状态，以及？？0视频1视频进入详细页2音频3音频详细页
        public static string FLP_mod = "";
        public static int totalnumberoffile =0;//单个列表的文件总数，暂时只写音频的
    }
}
    


