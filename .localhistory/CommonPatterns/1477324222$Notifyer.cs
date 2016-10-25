using System.ComponentModel;

namespace CommonPatterns
{
   public class Notifyer<T>: INotifyPropertyChanging
   {
      public event PropertyChangingEventHandler PropertyChanging;
      public Notifyer<T>()
      {
      
   }
   }
}
