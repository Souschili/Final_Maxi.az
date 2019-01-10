using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



//
//1. класс Лаптопов в отдельном файле
// 2. шаблон данных как статик ресурс(из неудачного проекта новый рисовать не хочу)
// 3. прикручен к листбоксу шаблон,и поставшик данных mycollection
// 4. Прикрутил 3 модели ноута Acer Extensa EX2508-C5W6,HP 250 G6 (1XP19ES) Dark Ash, MSI GP62M 7RDX(WOT Edition) 
// 5. Допилить класс цены и тд.
// 6. Класс допилен с тремя конструкторами ,пустой,урезаный,полный + начения по умолчанию (это для упрощения тестов)
// TODO Прикрутить интерфейс оповещатель 
// 7. Все прикрутил и добавил звездочки.
namespace Final_Maxi.az
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // тестовый вариант с проверкой вывода рисунка 
        //public Laptop test { get; set; } = new Laptop();


        
       public ObservableCollection<Laptop> mycollection { get; set; } = new ObservableCollection<Laptop>();
        
        public MainWindow()
        {
            InitializeComponent();
            //данные получаем из класса Лаптоп
            //this.DataContext = this;// или  new Laptop();

            mycollection.Add(new Laptop("image/Acer Extensa EX2508-C5W6 .jpg", "Acer Extensa EX2508-C5W6"));
            mycollection.Add(new Laptop("image/HP 250 G6 (1XP19ES) Dark Ash.jpg", "HP 250 G6 (1XP19ES) Dark Ash"));

            //проверка на фулл конструктор ,все ок. но выше для упрощения использовал урезанный конструктор(см. класс)
            mycollection.Add(new Laptop("image/MSI _WOT.jpg", "MSI GP62M 7RDX(WOT Edition)","Windows 8.1",16,850,21,"no",365.85,325.99));

            // тут только значения по умолчанию
            mycollection.Add(new Laptop());


            //сишарп вариант ,но можно было и в листе itemsource="{Binding Path=mycollection}" 
            //но тогда контекст меняем this.DataContext = this;
            //так же можно обойтись вообще без дата контекста достаточно иметь коллекцию обьектов
            //(отключение датаконтекста показало правоту этого утверждения)
            NoutView.ItemsSource = mycollection;
        }

    }
}
