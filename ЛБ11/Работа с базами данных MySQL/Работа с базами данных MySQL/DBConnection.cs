using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Data;

namespace Работа_с_базами_данных_MySQL
{
    internal class DBConnection
    {
        static string connectionString = "Database = myrmanrub; Data Source = 127.0.0.1; port = 3306; UserID = root; Password = 626458510A"; //строка подключения
        static MySqlConnection MySqlConnection; //объект для установки соединения с БД
        static MySqlCommand MySqlCommand; //объект для выполнения запросов
        static public MySqlDataAdapter MySqlDataAdapter;
        static public string User;
        static public string Role;
        static public DataTable dtUsers = new DataTable();
        static public DataTable dtCustomers = new DataTable();
        static public DataTable dtWhProductsCount = new DataTable();
        static public DataTable dtDetailsProduct = new DataTable();
        static public DataTable dtWriteOff = new DataTable();
        static public DataTable dtAssortiment = new DataTable();
        static public DataTable dtOrders = new DataTable();
        static public DataTable dtProductsFromStore = new DataTable();
        static public DataTable dtPositionIDFromStore = new DataTable();
        static public DataTable dtSalesForAdmin= new DataTable();





        //установка соединения с БД
        static public bool Connect()
        {
            try
            {
                //создание объекта соединения с заданной строкой подключения
                MySqlConnection = new MySqlConnection(connectionString);
                MySqlConnection.Open(); //открытие подключение
                                        //создание объекта-запрос
                MySqlCommand = new MySqlCommand();
                MySqlCommand.Connection = MySqlConnection;
                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                return true; //результат «истина»
            }
             catch (Exception ex) //при возникновении ошибки
            {
                //вывод сообщения
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Ошибка!");
                return false; //результат «ложь»
            }
           
        }
        //отключение соединения с БД
        static public void Close()
        {
            MySqlConnection.Close();
        }

        static public void Authorization(string login, string password)
        {
            try
            {
                //формируем запрос: выбрать поле из таблицы значения,
                //где логин и пароль равны введенным пользователем значениям
                string sql = "SELECT Role FROM Users WHERE Login = '" + login
                 + "' AND Password = '" + password + "' ;";
                //создаем объект-запрос
                MySqlCommand = new MySqlCommand(sql, MySqlConnection);
                //фиксируем результат запроса
                Object result = MySqlCommand.ExecuteScalar();
                //если в результате выполнения запроса получено непустое значение
                if (result != null)
                {
                    //заполняем информацию об авторизованном пользователе
                    Role = result.ToString();
                    User = login;
                }
                else
                {
                    //иначе тип пользователя - неавторизованный
                    Role = null;
                }
            }
            catch (Exception ex) //при возникновении ошибки
            {
                Role = User = null; //обнуляем значения полей
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
        //метод получения списка пользователей
        //selectedRole – значение роли для фильтрации
        //по умолчанию = null
        static public void GetUserList(string selectedRole = null)
        {
            if (selectedRole == null)
                MySqlCommand.CommandText = "SELECT * FROM users";
            else
            {
                MySqlCommand.CommandText = $"SELECT * FROM users WHERE users.Role = '{selectedRole}'";
            }
            dtUsers.Clear();
            MySqlDataAdapter.SelectCommand = MySqlCommand;
            MySqlDataAdapter.Fill(dtUsers);
        }


        // Получение заказчиков
        static public void GetCustomerList()
        {
            MySqlCommand.CommandText = "SELECT * FROM customers";
            dtCustomers.Clear();
            MySqlDataAdapter.SelectCommand = MySqlCommand;
            MySqlDataAdapter.Fill(dtCustomers);
        }


        //добавление нового пользователя
        static public bool AddUser(string login, string password, string Role)
        {
            //формирование запроса
            MySqlCommand.CommandText = $"INSERT INTO users " +
                                    $"VALUES('{login}', '{password}', '{Role}')";
            //выполение запроса
            if (MySqlCommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        //добавление нового заказчика
        static public void AddCustomer(string user, string name, string telephone, string
        adress, string email = null)
        {
            //формирование запроса
            MySqlCommand.CommandText = "INSERT INTO customers VALUES('" + user + "','" + name
             + "','" + telephone + "','" + email + "','" + adress + "');";
            //выполение запроса
            MySqlCommand.ExecuteNonQuery();
        }

        // Редактирование заказчика
        static public void EditCustomer(string user, string name, string phone, string address, string email = null)
        {
            MySqlCommand.CommandText = $"UPDATE customers " +
                                    $"SET Name = '{name}', Telephone = '{phone}', Email = '{email}', Adress = '{address}'" +
                                    $"WHERE User = '{user}'";

            MySqlCommand.ExecuteNonQuery();
        }
        // Удаление заказчика
        static public void DeleteCustomer(string user)
        {
            MySqlCommand.CommandText = $"DELETE FROM customers WHERE User = '{user}'";
            MySqlCommand.ExecuteNonQuery();
        }


        // Выбираем данные из БД по определенному столбцу и значению 
        static public void SelectCustomers(string nameColumn, string valueColumn)
        {
            MySqlCommand.CommandText = $"SELECT * FROM customers WHERE {nameColumn} = '{valueColumn}'";
            dtCustomers.Clear();
            MySqlDataAdapter.SelectCommand = MySqlCommand;
            MySqlDataAdapter.Fill(dtCustomers);
        }
        // Получение количества продуктов
        static public void GetCountProducts()
        {
            MySqlCommand.CommandText = "SELECT assortiment.Product, assortiment.Name, SUM(store.Count) AS Count " +
                                    "FROM assortiment " +
                                    "INNER JOIN store USING(Product) " +
                                    "WHERE Count > 0 " +
                                    "GROUP BY Product;";
            dtWhProductsCount.Clear();
            MySqlDataAdapter.SelectCommand = MySqlCommand;
            MySqlDataAdapter.Fill(dtWhProductsCount);
        }


        // Получить детальную информацию о продукте
        static public void GetDetailsProduct(string product)
        {
            MySqlCommand.CommandText = $"SELECT store.Date, store.Count " +
                                    $"FROM assortiment " +
                                    $"INNER JOIN store USING (Product) " +
                                    $"WHERE Product = '{product}';";
            dtDetailsProduct.Clear();
            MySqlDataAdapter.SelectCommand = MySqlCommand;
            MySqlDataAdapter.Fill(dtDetailsProduct);
        }
        // Получить категории
        static public List<string> GetCategories()
        {
            DataTable categories = new DataTable();
            List<string> res = new List<string>();
            MySqlCommand.CommandText = "SELECT Description FROM categories;";
            MySqlDataAdapter.SelectCommand = MySqlCommand;
            MySqlDataAdapter.Fill(categories);

            foreach (DataRow row in categories.Rows)
                foreach (object cell in row.ItemArray)
                    res.Add(cell.ToString());
            return res;
        }

        // Получить продукты в ассортименте 
        static public List<string> GetProducts()
        {
            DataTable products = new DataTable();
            List<string> res = new List<string>();

            MySqlCommand.CommandText = $"SELECT Name FROM assortiment";
            MySqlDataAdapter.SelectCommand = MySqlCommand;
            MySqlDataAdapter.Fill(products);

            foreach (DataRow row in products.Rows)
                foreach (object cell in row.ItemArray)
                    res.Add(cell.ToString());
            return res;

        }


        // Добавить новую поставку
        static public void AddSupply(int indProduct, int count, string date)
        {
            MySqlCommand.CommandText = $"INSERT INTO store (Product, Count, Date) " +
                $"VALUES('{indProduct + 1}', '{count}', '{date}')";
            MySqlCommand.ExecuteNonQuery();
        }
        static public void GetProductsByCategory(int indCategory)
        {
            MySqlCommand.CommandText = $"SELECT assortiment.Product, assortiment.Name, SUM(store.Count) AS Count " +
                                    $"FROM assortiment " +
                                    $"INNER JOIN store USING(Product) " +
                                    $"WHERE Count > 0 AND assortiment.Category = {indCategory + 1} " +
                                    $"GROUP BY Product;";
            dtWhProductsCount.Clear();
            MySqlDataAdapter.SelectCommand = MySqlCommand;
            MySqlDataAdapter.Fill(dtWhProductsCount);
        }


        // Списание просроченных товаров
        static public int WriteOff()
        {
            MySqlCommand.CommandText = $"SELECT store.PositionID, store.Product, store.Count, store.Date, assortiment.Shelflife " +
                                    $"FROM store " +
                                    $"INNER JOIN assortiment USING(Product) " +
                                    $"WHERE To_DAYS(CURDATE())-TO_DAYS(store.Date) >= assortiment.Shelflife;";

            dtWriteOff.Clear();
            MySqlDataAdapter.SelectCommand = MySqlCommand;
            MySqlDataAdapter.Fill(dtWriteOff);

            foreach (DataRow row in dtWriteOff.Rows)
            {
                DateTime date = new DateTime();
                date = (DateTime)row[3];

                MySqlCommand.CommandText = $"INSERT INTO write_off (Product, Count, Date, DateOff)" +
                                        $"VALUES ('{row[1]}', '{row[2]}', '{date.ToString("yyyy-MM-dd")}', '{DateTime.Today.ToString("yyyy-MM-dd")}');";
                MySqlCommand.ExecuteNonQuery();
                MessageBox.Show("ntcn");
                MySqlCommand.CommandText = $"DELETE FROM store WHERE PositionID = {row[0]};";
                MySqlCommand.ExecuteNonQuery();
            }
            return dtWriteOff.Rows.Count;
        }

        // Получить ассортимент
        static public void GetAssrotiment()
        {
            MySqlCommand.CommandText = $"SELECT * FROM assortiment;";

            MySqlDataAdapter.SelectCommand = MySqlCommand;
            dtAssortiment.Clear();
            MySqlDataAdapter.Fill(dtAssortiment);
        }
        // Получение заказов определенного пользователя
        static public void GetOrders()
        {
            MySqlCommand.CommandText = $"SELECT sales.Date, assortiment.Name, positionsinsale.Count " +
                                    $"FROM sales " +
                                    $"INNER JOIN positionsinsale ON positionsinsale.Sale = sales.SaledID " +
                                    $"INNER JOIN store ON positionsinsale.Product = store.PositionID " +
                                    $"INNER JOIN assortiment ON store.Product = assortiment.Product " +
                                    $"WHERE sales.Customer = '{User}';";
            MySqlDataAdapter.SelectCommand = MySqlCommand;
            dtOrders.Clear();
            MySqlDataAdapter.Fill(dtOrders);
        }

        static public void GetProductsFromStore()
        {
            MySqlCommand.CommandText = $"SELECT DISTINCT assortiment.Name FROM store " +
                                    $"INNER JOIN assortiment USING(Product);";
            MySqlDataAdapter.SelectCommand = MySqlCommand;
            dtProductsFromStore.Clear();
            MySqlDataAdapter.Fill(dtProductsFromStore);
        }
        static public string GetPositionIDFromStoreByProduct(string nameProduct)
        {
            MySqlCommand.CommandText = $"SELECT PositionID " +
                                    $"FROM store " +
                                    $"WHERE Product = " +
                                        $"(SELECT Product " +
                                        $"FROM assortiment " +
                                        $"WHERE Name = '{nameProduct}');";
            object res = MySqlCommand.ExecuteScalar();
            return res.ToString();


        }

        // Оформить заказ
        static public void CheckOut(int productID, int count)
        {
            MySqlCommand.CommandText = $"INSERT INTO sales (Customer, Date) " +
                                    $"VALUES ('{User}', '{DateTime.Now.ToString("yyyy-MM-dd")}')";
            MySqlCommand.ExecuteNonQuery();

            MySqlCommand.CommandText = $"SELECT MAX(SaledID) FROM sales";
            object res = MySqlCommand.ExecuteScalar();
            int indSale = Int32.Parse(res.ToString());

            MySqlCommand.CommandText = $"INSERT INTO positionsinsale " +
                                    $"VALUES ({indSale}, {productID}, {count});";
            MySqlCommand.ExecuteNonQuery();

            MySqlCommand.CommandText = $"UPDATE store " +
                                    $"SET Count = Count - {count} " +
                                    $"WHERE PositionID = {productID};";
            MySqlCommand.ExecuteNonQuery();
        }
        static public void GetSalesForAdmin()
        {
            MySqlCommand.CommandText = $"SELECT sales.Customer, sales.Date, assortiment.Name, positionsinsale.Count " +
                                    $"FROM sales " +
                                    $"INNER JOIN positionsinsale ON positionsinsale.Sale = sales.SaledID " +
                                    $"INNER JOIN store ON positionsinsale.Product = store.PositionID " +
                                    $"INNER JOIN assortiment ON store.Product = assortiment.Product;";
            MySqlDataAdapter.SelectCommand = MySqlCommand;
            dtSalesForAdmin.Clear();
            MySqlDataAdapter.Fill(dtSalesForAdmin);
        }
    }




}
