using System;

namespace lab5
{
	class Program
    {
		/// <summary>
        /// �������� ���� ���������, ���������� �� �� �����������������
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Client.ClientCode(facade);
        }
    }
    /// <summary>
    /// ����� ������
    /// </summary>
    public class Facade
    {
        protected Subsystem1 _subsystem1;
        
        protected Subsystem2 _subsystem2;

		/// <summary>
        /// ����������� ������
        /// </summary>
        /// <param name="subsystem1">���������� 1</param>
		/// <param name="subsystem2">���������� 2</param>
        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }
        

		/// <summary>
        /// ��������� ��� ������������� ����������
        /// </summary>
        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.operation1();
            result += this._subsystem2.operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.operationN();
            result += this._subsystem2.operationZ();
            return result;
        }
    }
    
    /// <summary>
    /// ����� 1 ����������
    /// </summary>
    public class Subsystem1
    {
		/// <summary>
        /// ��������� ���������� 1 ����������
        /// </summary>
        public string operation1()
        {
            return "Subsystem1: Ready!\n";
        }
		
		/// <summary>
        /// ��������� Go
        /// </summary>
        public string operationN()
        {
            return "Subsystem1: Go!\n";
        }
    }
    
    /// <summary>
    /// ����� 2 ����������
    /// </summary>
    public class Subsystem2
    {
		/// <summary>
        /// ��������� ���������� 2 ����������
        /// </summary>
        public string operation1()
        {
            return "Subsystem2: Get ready!\n";
        }
		
		/// <summary>
        /// ��������� Fire
        /// </summary>
        public string operationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }

	/// <summary>
    /// ���������� �����
    /// </summary>
    class Client
    {
        // <summary>
        /// ��������� ���� �������
        /// </summary>
        /// <param name="facade">Facade</param>
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
    
    
}