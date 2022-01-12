using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Strategy
    {
        public abstract void Do();
    }
    public class ViewPanel : Strategy 
    {
        public override void Do()
        {
            Console.WriteLine("Открывается панель выбора категории трансляции");
        }
    }
    public class Stream : Strategy 
    {
        public override void Do()
        {
            Console.WriteLine("Воспроизведение выбранного стрима ");
        }
    }
    public class ShowChat : Strategy 
    {
        public override void Do()
        {
            Console.WriteLine("Отображение live чата");
        }
    }
}
