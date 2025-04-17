using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab7_Zadanie_DNA.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    public void Button_Click(object source, RoutedEventArgs args)
    {
        wyjscie.Text = "";
        Dictionary<string, int> counts = new();

            string seq = wejscie.Text;
            for (int i = 0; i <= seq.Length - 4; i++)
            {
                string subseq = seq.Substring(i, 4);
                if (counts.ContainsKey(subseq))
                    counts[subseq]++;
                else
                    counts[subseq] = 1;
            }
            foreach (var pair in counts)
            {
                wyjscie.Text += $"{pair.Key}: {pair.Value}\n";
            }
        
    }
}
