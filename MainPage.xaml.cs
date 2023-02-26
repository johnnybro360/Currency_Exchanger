using System.Globalization;

namespace Currency_Exchanger;

public partial class MainPage : ContentPage
{
	CurrencyManager manager = new CurrencyManager();
    CultureInfo usCulture = new CultureInfo("en-US");

    public MainPage()
	{
		InitializeComponent();
		Refresh();
    }

	private void Refresh()
	{
        TotalLabel.Text = $"{manager.TotalCash().ToString("C2", usCulture)}";

		DollarQtyLabel.Text = $"$1\nx{manager.DollarQty}";
		DollarTotalLabel.Text = $"{manager.DollarQty.ToString("C2", usCulture)}";

		FiftyQtyLabel.Text = $"50c\nx{manager.FiftyCentQty}";
		FiftyTotalLabel.Text = $"{Convert.ToDouble(manager.FiftyCentQty * 0.50).ToString("C2", usCulture)}";

		TenQtyLabel.Text = $"10c\nx{manager.TenCentQty}";
		TenTotalLabel.Text = $"{Convert.ToDouble(manager.TenCentQty * 0.10).ToString("C2", usCulture)}";

		FiveQtyLabel.Text = $"5c\nx{manager.FiveCentQty}";
		FiveTotalLabel.Text = $"{Convert.ToDouble(manager.FiveCentQty * 0.05).ToString("C2", usCulture)}";
    }

    private void DollarAddButton_Pressed(object sender, EventArgs e)
    {
        manager.AddCurrency("dollar");
        Refresh();
    }

    private void DollarTakeButton_Pressed(object sender, EventArgs e)
    {
        manager.TakeCurrency("dollar");
        Refresh();
    }

    private void DollarToFiftyButton_Pressed(object sender, EventArgs e)
    {
        manager.DollarTransferDown();
        Refresh();
    }

    private void FiftyAddButton_Pressed(object sender, EventArgs e)
    {
        manager.AddCurrency("fiftyCent");
        Refresh();
    }

    private void FiftyTakeButton_Pressed(object sender, EventArgs e)
    {
        manager.TakeCurrency("fiftyCent");
        Refresh();
    }

    private void FiftyToDollarButton_Pressed(object sender, EventArgs e)
    {
        manager.FiftyTransfer("up");
        Refresh();
    }

    private void FIftyToTenButton_Pressed(object sender, EventArgs e)
    {
        manager.FiftyTransfer("down");
        Refresh();
    }

    private void TenAddButton_Pressed(object sender, EventArgs e)
    {
        manager.AddCurrency("tenCent");
        Refresh();
    }

    private void TenTakeButton_Pressed(object sender, EventArgs e)
    {
        manager.TakeCurrency("tenCent");
        Refresh();
    }

    private void TenToFiftyButton_Pressed(object sender, EventArgs e)
    {
        manager.TenTransfer("up");
        Refresh();
    }

    private void TenToFiveButton_Pressed(object sender, EventArgs e)
    {
        manager.TenTransfer("down");
        Refresh();
    }

    private void FiveAddButton_Pressed(object sender, EventArgs e)
    {
        manager.AddCurrency("fiveCent");
        Refresh();
    }

    private void FiveTakeButton_Pressed(object sender, EventArgs e)
    {
        manager.TakeCurrency("fiveCent");
        Refresh();
    }

    private void FiveToTenButton_Pressed(object sender, EventArgs e)
    {
        manager.FiveTransferUp();
        Refresh();
    }
}

