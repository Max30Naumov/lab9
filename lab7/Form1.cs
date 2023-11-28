namespace lab7
{
    public partial class Form1 : Form
    {
        private HospitalQueue _hospitalQueue;
        private Sorting _sorting;
        private Serialization _serialization;
        private Filtering _filtering;
        public Form1()
        {
            InitializeComponent();
            _hospitalQueue = new HospitalQueue();
            _sorting = new Sorting();
            _serialization = new Serialization();
            _filtering = new Filtering();

        }

        private void btShow_Click(object sender, EventArgs e)
        {
            UpdateQueueListBox();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string firstName = TBFirstName.Text;
            string lastName = TBLastName.Text;

            //проверка на правильный ввод
            if (int.TryParse(TBAge.Text, out int age) && int.TryParse(TBId.Text, out int id))
            {
                Patient patient = new Patient(firstName, lastName, age, id);
                _hospitalQueue.AddPatient(patient);
                UpdateQueueListBox(); //обновляем список очереди
            }
            else
            {
                MessageBox.Show("Неправильный формат введенных данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // очстка текстовых полей
            TBFirstName.Clear();
            TBLastName.Clear();
            TBAge.Clear();
            TBId.Clear();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            _hospitalQueue.RemoveFirstPatient(); // удаляем первого пациента из очереди 
            UpdateQueueListBox();
        }
        private void UpdateQueueListBox()
        {
            listBoxQuque.Items.Clear();
            string queueInfo = _hospitalQueue.DisplayQueue();
            // разделение строки queueInfo на массив подстрок для красивого и корректного ввывода в листбокс
            string[] patientInfoArray = queueInfo.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            // добавляем информацию о пациентах в список очереди
            foreach (string patientInfo in patientInfoArray)
            {
                listBoxQuque.Items.Add(patientInfo);
            }
        }

        private void SerializeToJsonBtn_Click(object sender, EventArgs e)
        {
            string filePath = "hospitalQueue.json";
            _serialization.SerializeToJson(_hospitalQueue._patientsQueue, filePath);

        }

        private void DeserializeFromJsonBtn_Click(object sender, EventArgs e)
        {
            string filePath = "hospitalQueue.json";
            HospitalQueue deserializedQueue = Serialization.DeserializeFromJson(filePath);
            _hospitalQueue = deserializedQueue;
            UpdateQueueListBox();

        }

        private void SerializeToBinaryBtn_Click(object sender, EventArgs e)
        {
            string filePath = "hospitalQueue.bin";
            _serialization.SerializeToBinary(_hospitalQueue._patientsQueue, filePath);

        }

        private void DeserializeFromBin_Click(object sender, EventArgs e)
        {
            string filePath = "hospitalQueue.bin";
            HospitalQueue loadedQueue = Serialization.DeserializeFromBinary(filePath);
            _hospitalQueue = loadedQueue;
            UpdateQueueListBox();


        }

        private void SortAgeAsc_Click(object sender, EventArgs e)
        {
            _sorting.SortByAgeAscending(_hospitalQueue);
            UpdateQueueListBox();
        }

        private void SortAgeDesc_Click(object sender, EventArgs e)
        {
            _sorting.SortByAgeDescending( _hospitalQueue);
            UpdateQueueListBox();
        }

        private void SortIDAsc_Click(object sender, EventArgs e)
        {
            _sorting.SortByIdAscending(_hospitalQueue);
            UpdateQueueListBox();
        }

        private void SortIdDesc_Click(object sender, EventArgs e)
        {
            _sorting.SortByIdDescending( _hospitalQueue);
            UpdateQueueListBox();
        }

        private void SearchByName_Click(object sender, EventArgs e)
        {
            string searchValue = TBFirstName.Text;
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                // поиск по имени с использованием делегата
                HospitalQueue filteredQueue = _filtering.FilterByFirstName( _hospitalQueue, searchValue);

                //вывод в листбокс

                listBoxQuque.Items.Clear();
                string queueInfo = filteredQueue.DisplayQueue();
                // разделение строки queueInfo на массив подстрок для красивого и корректного ввывода в листбокс
                string[] patientInfoArray = queueInfo.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                // добавляем информацию о пациентах в список очереди
                foreach (string patientInfo in patientInfoArray)
                {
                    listBoxQuque.Items.Add(patientInfo);
                }
            }
            else MessageBox.Show("Введите значение для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SearchLastName_Click(object sender, EventArgs e)
        {
            string searchValue = TBLastName.Text;
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                // поиск  по фамилии с использованием лямбда-выражения
                HospitalQueue filteredQueue = _filtering.FilterByLastName( _hospitalQueue, searchValue);
                //вывод в листбокс

                listBoxQuque.Items.Clear();
                string queueInfo = filteredQueue.DisplayQueue();
                // разделение строки queueInfo на массив подстрок для красивого и корректного ввывода в листбокс
                string[] patientInfoArray = queueInfo.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                // добавляем информацию о пациентах в список очереди
                foreach (string patientInfo in patientInfoArray)
                {
                    listBoxQuque.Items.Add(patientInfo);
                }
            }
            else MessageBox.Show("Введите значение для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}