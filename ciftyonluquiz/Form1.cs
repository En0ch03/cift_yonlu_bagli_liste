using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cifyonlubagliliste
{
    public partial class Form1 : Form
    {

        // Çift yönlü bağlı liste düğümü
        public class Node
        {
            public int Data;
            public Node Next;
            public Node Prev;
        }

        private Node head; // Bağlı listenin başı

        public Form1()
        {

            InitializeComponent();

            head = null; // Başlangıçta bağlı liste boş
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Başa ekleme işlemi
            if (string.IsNullOrEmpty(InputTextBox.Text))
            {
                MessageBox.Show("Lütfen bir değer girin.");
                return;
            }

            int data = int.Parse(InputTextBox.Text);
            Node newNode = new Node();
            newNode.Data = data;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }

            UpdateList();
            InputTextBox.Clear();
        }

        private void AddToEndButton_Click(object sender, EventArgs e)
        {
            // Sona ekleme işlemi
            if (string.IsNullOrEmpty(InputTextBox.Text))
            {
                MessageBox.Show("Lütfen bir değer girin.");
                return;
            }

            int data = int.Parse(InputTextBox.Text);
            Node newNode = new Node();
            newNode.Data = data;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
                newNode.Prev = current;
            }

            UpdateList();
            InputTextBox.Clear();
        }

        private void RemoveFromStartButton_Click(object sender, EventArgs e)
        {
            // Baştan silme işlemi
            if (head != null)
            {
                head = head.Next;

                if (head != null)
                {
                    head.Prev = null;
                }

                UpdateList();
            }
            else
            {
                MessageBox.Show("Bağlı liste boş.");
            }
        }

        private void AddToStartButton_Click(object sender, EventArgs e)
        {
            // Başa ekleme işlemi
            if (string.IsNullOrEmpty(InputTextBox.Text))
            {
                MessageBox.Show("Lütfen bir değer girin.");
                return;
            }

            int data = int.Parse(InputTextBox.Text);
            Node newNode = new Node();
            newNode.Data = data;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }

            UpdateList();
            InputTextBox.Clear();
        }

        private void RemoveFromEndButton_Click(object sender, EventArgs e)
        {
            // Sondan silme işlemi
            if (head != null)
            {
                if (head.Next == null)
                {
                    head = null;
                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }

                    current.Prev.Next = null;
                }

                UpdateList();
            }
            else
            {
                MessageBox.Show("Bağlı liste boş.");
            }
        }
        private void UpdateList()
        {
            // Bağlı listeyi güncelle ve ListView'e ekle
            OutputListView.Items.Clear();

            Node current = head;
            while (current != null)
            {
                OutputListView.Items.Add(current.Data.ToString());
                current = current.Next;
            }
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
