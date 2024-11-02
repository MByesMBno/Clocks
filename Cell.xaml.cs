using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;

using System.Data.Common;

using System.Linq;
namespace Clocks;

public partial class Cell : ContentView
{
    private SolidColorBrush Aqua = new SolidColorBrush(Colors.Aqua);
    private SolidColorBrush DimGray = new SolidColorBrush(Colors.DimGray);
    static int[,] zeroMas = new int[,] { {2,0}, {3,0}, {4,0}, {1,1}, {1,2}, {1,3}, {5,1}, {5,2}, {5,3}, {2,6}, {3,6}, {4,6}, {1,4}, {1,5}, {5,4}, {5,5} };
    static int[,] firstMas = new int[,] {{ 1, 2 }, { 2, 1 }, { 3, 0 }, { 3, 1 }, { 3, 2 }, { 3, 3 }, { 3, 4 }, { 3, 5 }, { 3, 6 }, { 1, 6 }, { 2, 6 }, { 4, 6 }, { 5, 6 }};
    static int[,] secondMas = new int[,] {{ 2, 0 }, { 3, 0 }, { 4, 0 }, { 1, 1 }, { 5, 2 }, { 4, 3 }, { 3, 4 }, { 2, 5 }, { 1, 6 }, { 2, 6 }, { 3, 6 }, { 4, 6 }, { 5, 6 }, { 5, 1 } };
    static int[,] thirdMas = new int[,] {{ 2, 0 }, { 3, 0 }, { 4, 0 }, { 1, 1 }, { 5, 1 }, { 5, 2 }, { 5, 4 }, { 4, 3 }, { 2, 6 }, { 3, 6 }, { 4, 6 }, { 5, 5 }, { 1, 5 } };
    static int[,] fourthMas = new int[,] {{ 1, 0 }, { 1, 1 }, { 1, 2 }, { 1, 3 }, { 2, 3 }, { 1, 3 },{ 3, 3 }, { 4, 3 }, { 5, 3 }, { 5, 2 }, { 5, 1 }, { 5, 0 }, { 5, 4 }, { 5, 5 }, { 5, 6 }};
    static int[,] fifthMas = new int[,] {{ 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 },{ 1, 1 }, { 1, 2 }, { 2, 3 }, { 3, 3 }, { 4, 3 }, { 5, 4 }, { 5, 5 }, { 4, 6 }, { 3, 6 }, { 2, 6 }, { 1, 5 } };
    static int[,] sixthMas = new int[,] {{ 1, 4 }, { 1, 3 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 1 }, { 1, 2 }, { 2, 3 }, { 3, 3 }, { 4, 3 },{ 5, 4 }, { 5, 5 }, { 4, 6 }, { 3, 6 }, { 2, 6 },{ 1, 5 }, { 1, 1 }};
    static int[,] seventhMas = new int[,] {{ 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 },{ 5, 1 }, { 5, 2 }, { 4, 3 }, { 3, 4 }, { 2, 5 }, { 1, 6 } };
    static int[,] eightMas = new int[,] {{ 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 1 }, { 5, 2 },{ 2, 3 }, { 3, 3 }, { 4, 3 }, { 1, 1 }, { 1, 2 },{ 1, 4 }, { 1, 5 }, { 5, 4 }, { 5, 5 }, { 2, 6 }, { 3, 6 }, { 4, 6 } };
    static int[,] ninthMas = new int[,] { { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 1 }, { 5, 2 },{ 2, 3 }, { 3, 3 }, { 4, 3 }, { 1, 1 }, { 1, 2 },{ 5, 3 }, { 5, 4 }, { 5, 5 }, { 2, 6 }, { 3, 6 },{ 4, 6 }, { 1, 5 } };

    public Cell()
	{
		InitializeComponent();
	}
    private Rectangle GetLink(int column, int row)
    {
        return Field.Children.OfType<Rectangle>().FirstOrDefault(r => Grid.GetRow(r) == row && Grid.GetColumn(r) == column);
    }
    private void FillCells(int[,] mas) {
        Rectangle rectangle;
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            rectangle = GetLink(mas[i, 0], mas[i, 1]);
            rectangle.Fill = Aqua;
        }
    }
    public void ClearCell() {
        foreach (var child in Field.Children)
        {
            if (child is Rectangle rectangle)
                rectangle.Fill = DimGray;
        }
    }
 
    public void PrintNumber(int number)
    {
        switch (number)
        {
            case 0:
                FillCells(zeroMas);
                break;
            case 1:
                FillCells(firstMas);
                break;
            case 2:
                FillCells(secondMas);
                break;
            case 3:
                FillCells(thirdMas);
                break;
            case 4:
                FillCells(fourthMas);
                break;
            case 5:
                FillCells(fifthMas);
                break;
            case 6:
                FillCells(sixthMas);
                break;
            case 7:
                FillCells(seventhMas);
                break;
            case 8:
                FillCells(eightMas);
                break;
            case 9:
                FillCells(ninthMas);
                break;
        }
    }
}