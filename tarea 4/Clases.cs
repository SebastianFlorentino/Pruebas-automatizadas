using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenQA.Selenium.Support.Extensions;

namespace tarea_4
{
    internal class Clases
    {

        IWebDriver driver = new FirefoxDriver();


        public void AbrirNavegador()
        {
            driver.Navigate().GoToUrl("https://es.wikipedia.org/wiki/Wikipedia:Portada");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);


        }



        public void Buscar()
        {
            AbrirNavegador();

            IWebElement buscador = driver.FindElement(By.ClassName("cdx-text-input__input"));
            buscador.SendKeys("República Dominicana");
            buscador.Submit();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(25);
        


            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\fseba\\OneDrive - Instituto Tecnológico de Las Américas (ITLA)\\2024-C3\\Programacion III\\tarea 4\\img\\buscar.png");

            //driver.Close();



        }

        public void cambiarIdioma()
        {
            AbrirNavegador();

            IWebElement inputIdioma = driver.FindElement(By.Id("p-lang-btn-checkbox"));
            inputIdioma.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);

            IWebElement idiomaIngles = driver.FindElement(By.ClassName("autonym"));
            idiomaIngles.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\fseba\\OneDrive - Instituto Tecnológico de Las Américas (ITLA)\\2024-C3\\Programacion III\\tarea 4\\img\\idioma.png");

            //driver.Close();

        }

        public void entrarArticulo()
        {
            AbrirNavegador();

            //var link = RelativeBy.WithLocator(By.TagName("a")).Near(By.Id("h-Okuribito-Bienvenidos_a_Wikipedia,"));
            IWebElement link = driver.FindElement(By.XPath("//a[@href = '/wiki/Okuribito']"));
            link.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\fseba\\OneDrive - Instituto Tecnológico de Las Américas (ITLA)\\2024-C3\\Programacion III\\tarea 4\\img\\articulo.png");

            //driver.Close();


        }

        public void IniciarSesion()
        {
            AbrirNavegador();

            IWebElement boton = driver.FindElement(By.XPath("//a[@href = '/w/index.php?title=Especial:Entrar&returnto=Wikipedia%3APortada']"));
            boton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);

            IWebElement nombre = driver.FindElement(By.Id("wpName1"));
            nombre.SendKeys("Juan Gonzales Martinez");

            IWebElement pass = driver.FindElement(By.Id("wpPassword1"));
            pass.SendKeys("72cfkr15hd");

            IWebElement btn = driver.FindElement(By.Id("wpLoginAttempt"));
            btn.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\fseba\\OneDrive - Instituto Tecnológico de Las Américas (ITLA)\\2024-C3\\Programacion III\\tarea 4\\img\\iniciarSesion.png");

            //driver.Close();

        }

        public void VerPreferencias()
        {
            IniciarSesion();

            IWebElement checkbox = driver.FindElement(By.Id("vector-user-links-dropdown-checkbox"));
            checkbox.Click();

            IWebElement preferencias = driver.FindElement(By.XPath("//a[@href = '/wiki/Especial:Preferencias']"));
            preferencias.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\fseba\\OneDrive - Instituto Tecnológico de Las Américas (ITLA)\\2024-C3\\Programacion III\\tarea 4\\img\\preferencias.png");

            driver.Close();


        }
    }

    

}
