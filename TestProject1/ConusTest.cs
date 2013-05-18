using UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///Это класс теста для PyramidTest, в котором должны
    ///находиться все модульные тесты PyramidTest
    ///</summary>
    [TestClass()]
    public class ConusTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Тест для Конструктор Box
        ///</summary>
        [TestMethod()]
        public void ConusConstructorTest()
        {
            double radius = 0F; // TODO: инициализация подходящего значения
            double heigth = 0F; // TODO: инициализация подходящего значения
            Conus target = new Conus(radius, heigth);
          
        }

        /// <summary>
        ///Тест для GetVolume
        ///</summary>
        [TestMethod()]
        public void GetVolumeTest()
        {
            double radius = 2F; // TODO: инициализация подходящего значения
            double heigth = 3F; // TODO: инициализация подходящего значения
            Conus target = new Conus(radius, heigth); // TODO: инициализация подходящего значения
            double expected = 12.56F; // TODO: инициализация подходящего значения
            double actual;
            actual = target.GetVolume();
            Assert.IsTrue(Math.Abs(actual - expected) < 0.01);
          
        }

        /// <summary>
        ///Тест для Heigth
        ///</summary>
        [TestMethod()]
        public void HeigthTest()
        {
            double radius = 0F; // TODO: инициализация подходящего значения
            double heigth = 0F; // TODO: инициализация подходящего значения
            Conus target = new Conus(radius, heigth); // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            target.Heigth = expected;
            actual = target.Heigth;
            Assert.AreEqual(expected, actual);
         
        }

       

        /// <summary>
        ///Тест для Width
        ///</summary>
        [TestMethod()]
        public void RadiusTest()
        {
            double radius = 0F; // TODO: инициализация подходящего значения
            double heigth = 0F; // TODO: инициализация подходящего значения
            //double pi = 3.14F; // TODO: инициализация подходящего значения
            Conus target = new Conus(radius, heigth); // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            target.Radius = expected;
            actual = target.Radius;
            Assert.AreEqual(expected, actual);
          //  Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Конструктор Box
        ///</summary>
        [TestMethod()]
        public void ConusConstructorTest1()
        {
            double radius = 0F; // TODO: инициализация подходящего значения
            double heigth = 0F; // TODO: инициализация подходящего значения
           // double pi = 0F; // TODO: инициализация подходящего значения
            Conus target = new Conus(radius, heigth);
         //   Assert.Inconclusive("TODO: реализуйте код для проверки целевого объекта");
        }

        
        
    }
}
