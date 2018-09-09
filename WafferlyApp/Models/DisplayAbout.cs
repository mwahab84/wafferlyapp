using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BudgetSaver.Models
{
    public class DisplayAbout:Page
    {
        public DisplayAbout(){
            

            this.BackgroundColor = new Color(0, 0, 0, .5);
            var mScrollVu = new ScrollView();

            var mStackLay = new StackLayout();
            mStackLay.Parent = mScrollVu;
            mStackLay.Children.Add(new Label() { Text = "About", FontSize = 24, TextColor = new Color(0, 0, 0) });
            LayoutChildren(20, 20, 100, 200);
            //Size size = new Size(100,200);
            SizeAllocated(100, 200);
        }

        
        /*<ScrollView VerticalOptions = "FillAndExpand" HorizontalOptions="FillAndExpand">
            <StackLayout VerticalOptions = "FillAndExpand" HorizontalOptions="FillAndExpand" Orientation="Vertical">
                <Label Text = "About" FontSize="24" FontFamily="Arial" TextColor="Black"/>
                <StackLayout Orientation = "Horizontal" >
                    < Label Text="Company Logo"/>
                    <Label Text = "Molutions" />
                </ StackLayout >
            </ StackLayout >
        </ ScrollView >*/


	}
}
