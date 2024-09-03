using MaterialSkin;
using MaterialSkin.Controls;

namespace ExpenseTrackerWin2;

public partial class Index : MaterialForm
{
    public Index()
    {
        InitializeComponent();
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
    }
}