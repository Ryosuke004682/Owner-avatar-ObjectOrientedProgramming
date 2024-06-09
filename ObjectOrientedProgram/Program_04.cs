using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram
{
    public class Cabble {
        private  string CompanyName { get; } = "Taxi"; // 会社名
        private  string TaxiDriverName { get; set; } // ドライバーの名前
        private  VehicleName Vehicle { get; set; } // 選択された車両

        public enum VehicleName {
            Pri,
            Ate,
            Cab,
            MyCab
        }

        /// <summary>
        /// デフォルトのコンストラクタ
        /// </summary>
        public Cabble() {
            TaxiDriverName = null;//初期値の名前をnullにする。
            Vehicle = VehicleName.Cab;//初期値をカブに設定
        }

        /// <summary>
        /// CabbleのNameを初期化するコンストラクタ
        /// </summary>
        /// <param name="driverName">ドライバーの名前</param>
        /// <param name="vehicleName">車両名</param>
        public Cabble(string driverName, VehicleName vehicleName) {
            TaxiDriverName = driverName;
            Vehicle = vehicleName;
        }

        public string GetCompanyName() {
            return CompanyName;
        }

        public string GetTaxiDriverName() {
            return TaxiDriverName;
        }

        public VehicleName GetVehicle() {
            return Vehicle;
        }

        //---------パブリックインターフェース-------------
        public void GiveDestination() {
            // 目的地を設定するメソッドの実装
        }


        //-------プライベートな実装------------
        public void TurnRight() {
            // 右折するメソッドの実装
        }

        public void TurnLeft() {
            // 左折するメソッドの実装
        }
    }

    internal class Program_04
    {
        static void Main(string[] args)
        {
            Cabble cab = new Cabble("John Doe", Cabble.VehicleName.MyCab);
            Console.WriteLine($"Company: {cab.GetCompanyName()}");
            Console.WriteLine($"Driver: {cab.GetTaxiDriverName()}");
            Console.WriteLine($"Vehicle: {cab.GetVehicle()}");

            while (true) ;
        }
    }
}
