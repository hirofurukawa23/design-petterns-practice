using System;
using System.Reflection;

namespace AbstractFactory_pattern.Factory
{
    public abstract class Factory
    {
        public static Factory GetFactory(string className)
        {
            Factory factory = null;
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                factory = (Factory)assembly.CreateInstance("AbstractFactory_pattern.ListFactory.ListFactory");
            }
            catch(TypeLoadException ex)
            {
                Console.WriteLine($"クラス { className } が見つかりません。");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return factory;
        }

        public abstract Link CrateLink(string caption, string url);
        public abstract Tray CreateTray(string caption);
        public abstract Page CreatePage(string title, string author);
    }
}
