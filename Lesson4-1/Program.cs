/*1. Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов).
 * Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати.
 * Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д. 
 * Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. 
 * Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания,
 * и предусмотреть метод, который увеличивал бы значение этого поля.*/

namespace Lesson4
{
    public class Building

    {
        public Building()
        {
            AddNumberBuilding();

        }

        private static uint NumberBuilding { get; set; } = 1;
        private uint HeightBuilding { get; set; } = 28;
        private uint FloorBuilding { get; set; } = 10;
        private uint FlatBuilding { get; set; } = 120;
        private uint EntranceBuilding { get; set; } = 3;

        public double CalculatingHeightFloor()
        {

            double heightFloor = (double)HeightBuilding / FloorBuilding;
            return heightFloor;
        }

        public uint CalculatingFlatEntrance()
        {

            var flatEntrance = FlatBuilding / EntranceBuilding;
            return flatEntrance;
        }

        public uint CalculatingFlatFloor()
        {

            var calculationFlatEntrance = CalculatingFlatEntrance();
            var flatFloor = calculationFlatEntrance / FloorBuilding;
            return flatFloor;
        }

        public void AddNumberBuilding()
        {

            NumberBuilding++;

        }

        public uint ReadHeightBuilding()
        {
            return HeightBuilding;

        }
        public uint ReadFloorBuilding()
        {
            return FloorBuilding;

        }

        public uint ReadFlatBuilding()
        {
            return FlatBuilding;

        }

        public uint ReadEntranceBuilding()
        {
            return EntranceBuilding;

        }

        public uint ReadNumberBuildingg()
        {
            return NumberBuilding;

        }
        public void WriteHeightBuilding(uint height)
        {
            HeightBuilding = height;

        }
        public void WriteFloorBuilding(uint floor)
        {
            FloorBuilding = floor;

        }
        public void WriteFlatBuilding(uint flat)
        {
            FlatBuilding = flat;

        }
        public void WriteEntranceBuilding(uint entrance)
        {
            EntranceBuilding = entrance;

        }

        public void PrintBuilding()
        {
            var flatFloor = CalculatingFlatFloor();
            var heightFloor = CalculatingHeightFloor();
            var flatEntrance = CalculatingFlatEntrance();
            Console.WriteLine($"Номер дома: {NumberBuilding}");
            Console.WriteLine($"Высота дома: {HeightBuilding}м");
            Console.WriteLine($"Этажей в доме: {FloorBuilding}");
            Console.WriteLine($"Квартир в доме: {FlatBuilding}");
            Console.WriteLine($"Подъездов в доме: {EntranceBuilding}");
            Console.WriteLine($"Квартир на этаже: {flatFloor}");
            Console.WriteLine($"Высота этажа: {heightFloor}м");
            Console.WriteLine($"Квартир в подъезде: {flatEntrance}");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            var newHouse = new Building();
            newHouse.PrintBuilding();



        }

    }

}



    
