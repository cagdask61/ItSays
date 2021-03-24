using ItSays.Business.Abstract;
using ItSays.Business.Concrete;
using ItSays.DataAccess.Concrete.EntityFramework;
using ItSays.Entities.Concrete;
using System;
using System.Diagnostics;
using System.Linq;

namespace ItSays.ConsoleTestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ArticleManager articleManager = new ArticleManager(new EfArticleDal());
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //Article newArticle = new Article
            //{
            //    AuthorId = 3,
            //    Title = "Başarı",
            //    CategoryId = 3,
            //    Date = DateTime.Now,
            //    Writing = "Çalışmaya oturduğun zaman tıpkı ateş hattında düşmanı gözetleyen bir asker gibi uyanık ol ve dikkat kesil. Ve bütün ruhi ve bedeni kuvvetinle kendini işe ver."

            //};
            //articleManager.ArticleAdd(newArticle);



            foreach (var category in categoryManager.GetAllCategory().Data)
            {
                Console.WriteLine(category.Id +"--"+category.CategoryName);
            }


            Console.WriteLine("------");

            foreach (var article in articleManager.GetAll().Data)
            {
                Console.WriteLine(article.AuthorId + " -- "+ article.Title + " -- " + article.Date.Year +" -- "+article.Writing);
            }

            
            Console.ReadKey();
        }
    }
}
