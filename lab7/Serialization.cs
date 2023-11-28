using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Serialization
    {
        public void SerializeToJson(Queue<Patient> _patientsQueue, string filePath)
        {
            // проверка наличия пациентов в очереди
            if (_patientsQueue.Count > 0)
            {
                // создание списка для хранения существующих пациентов
                List<Patient> existingPatients = new List<Patient>();

                // проверка существования файла
                if (File.Exists(filePath))
                {
                    // если файл существует, считывание JSON-строки из файла
                    string existingJson = File.ReadAllText(filePath);
                    // проверка, не пустая ли JSON-строка
                    if (!string.IsNullOrEmpty(existingJson))
                    {
                        // десериализация JSON-строки в список пациентов
                        existingPatients = JsonConvert.DeserializeObject<List<Patient>>(existingJson);
                    }
                }

                // дбавление пациентов из очереди в список существующих пациентов
                foreach (var patient in _patientsQueue)
                {
                    existingPatients.Add(patient);
                }

                // преобразование списка пациентов обратно в JSON-формат
                string updatedJson = JsonConvert.SerializeObject(existingPatients);

                // запись обновленной JSON-строки обратно в файл
                File.WriteAllText(filePath, updatedJson);

                MessageBox.Show("Новые данные успешно добавлены в JSON-файл.", "Успешная сохранность", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Очередь пациентов пуста. Данные не будут сохранены.", "Пустая очередь", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
     // метод для десериализации данных из JSON
        public static HospitalQueue DeserializeFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                // читание содержимого JSON
                string json = File.ReadAllText(filePath);

                // проверка, не пустая ли JSON строка
                if (!string.IsNullOrEmpty(json))
                {
                    // десериализуем JSON строку в список 
                    var patients = JsonConvert.DeserializeObject<List<Patient>>(json);
                    // создание нового объекта HospitalQueue и добавление пациентов
                    HospitalQueue hospitalQueue = new HospitalQueue();
                    // отключаем уведомления о добавлении пациентов, так как файл может быть большим
                    hospitalQueue.SetShowMessageOnAdd(false);
                    foreach (var patient in patients)
                    {
                        hospitalQueue.AddPatient(patient);
                    }
                   
                    return hospitalQueue;
                }
                else
                {
                    throw new InvalidOperationException("Файл пустой.");
                }

            }
            else
            {
                throw new FileNotFoundException("Файл не найден.");
            }


        }

        // метод для сериализации данных в бинарный файл
        public void SerializeToBinary(Queue<Patient> _patientsQueue, string filePath)
        {
            // проверка наличия данных в текущей очереди _patientsQueue
            if (_patientsQueue.Count > 0)
            {
                // ссоздание очереди для хранения объединенных данных
                Queue<Patient> combinedQueue = new Queue<Patient>();
                // cоздаем временную очередь для сохранения данных из _patientsQueue
                Queue<Patient> tempQueue = new Queue<Patient>(_patientsQueue);

                // проверка наличия файла и его содержимого
                if (File.Exists(filePath))
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                    {
                        if (fileStream.Length > 0)
                        {
                            // десериализация данных из файла в комбинированную очередь
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            combinedQueue = (Queue<Patient>)binaryFormatter.Deserialize(fileStream);
                        }
                    }
                }

                // добавление элементов из очереди _patientsQueue в combinedQueue
                while (tempQueue.Count > 0)
                {
                    combinedQueue.Enqueue(tempQueue.Dequeue());
                }
                // запись сериализованных данных в файл
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, combinedQueue);
                }

                MessageBox.Show("Данные успешно сохранены в BIN-файле.", "Успешная сохранность", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Очередь пациентов пуста. Данные не будут сохранены.", "Пустая очередь", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // метод для десериализации данных из бинарного файла
        public static HospitalQueue DeserializeFromBinary(string filePath)
        {
            // проверка существуетт ли файл 
            if (File.Exists(filePath))
            {
                // проверка пуст ли файл
                if (new FileInfo(filePath).Length > 0)
                {
                    // открываем файл для чтения
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                    {
                        //  объект BinaryFormatter для десериализации
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        // десериализация очереди пациентов из файла
                        Queue<Patient> patients = (Queue<Patient>)binaryFormatter.Deserialize(fileStream);
                        HospitalQueue hospitalQueue = new HospitalQueue();
                        //восстанавление очереди пациентов
                        hospitalQueue._patientsQueue = patients;

                      
                        return hospitalQueue;
                    }
                }
                else
                {
                    throw new InvalidOperationException("Файл пустой.");
                }
            }
            else
            {
                throw new FileNotFoundException("Файл не найден.");
            }
        }
    }
}
