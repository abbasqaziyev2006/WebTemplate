namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();

            app.UseRouting();
            app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");
            app.Run();
        }
    }
}
