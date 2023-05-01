using System;
using System.Data.Entity;
using System.Linq;

namespace Kursovaya.Model
{
    public class LibContext : DbContext
    {
        // Контекст настроен для использования строки подключения "LibContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Kursovaya.Model.LibContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "LibContext" 
        // в файле конфигурации приложения.
        public LibContext()
            : base("name=LibContext")
        {
        }

        public DbSet<Personal> Personals { get; set; }
        public DbSet<Zayavka> Zayavkas { get; set; }
        public DbSet<Dishes> Dishes { get; set; }
        public DbSet<Zakaz> Zakazs { get; set; }
        public DbSet<Check> Checks { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}