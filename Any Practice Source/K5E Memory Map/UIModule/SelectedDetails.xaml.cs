﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

using System;
using System.IO;
using System.Diagnostics;

namespace K5E_Memory_Map.UIModule
{
    /// <summary>
    /// Interaction logic for SelectedDetails.xaml
    /// </summary>
    public partial class SelectedDetails : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow _MainWindow;


        private TreeNode _currentnode;
        public TreeNode CurrentNode
        {
            get => _currentnode;
            set
            {
                if (true)
                {
                    _currentnode = value;

                    Hash = CurrentNode.Mem;
                    NodeTag = CurrentNode.TagText;
                    NodeText = CurrentNode.Text;
                    if (CurrentNode.Stated)
                    {
                        Stated = "Yes";
                    }
                    else
                    {
                        Stated = "No";
                    }
                    OnPropertyChanged(nameof(CurrentNode));
                }
            }
        }

        private string? _hash;
        public string? Hash
        {
            get => _hash;
            set
            {
                if (_hash != value)
                {
                    _hash = value;
                    OnPropertyChanged(nameof(Hash));
                }
            }
        }

        private string? _nodetag;
        public string? NodeTag
        {
            get => _nodetag;
            set
            {
                if (_nodetag != value)
                {
                    _nodetag = value;
                    OnPropertyChanged(nameof(NodeTag));
                }
            }
        }

        private string? _nodetext;
        public string? NodeText
        {
            get => _nodetext;
            set
            {
                if (_nodetext != value)
                {
                    _nodetext = value;
                    OnPropertyChanged(nameof(NodeText));
                }
            }
        }

        private string? _stated;
        public string? Stated
        {
            get => _stated;
            set
            {
                if (_stated != value)
                {
                    _stated = value;
                    OnPropertyChanged(nameof(Stated));
                }
            }
        }




        public SelectedDetails()
        {
            InitializeComponent();
            DataContext = this;
        }


        private void SaveText(object sender, RoutedEventArgs e)
        {
            CurrentNode.Text = TextInput.Text;
            TextInput.Text = "";
            _MainWindow.UpdateGraphs();
        }

        private void DelNode(object sender, RoutedEventArgs e)
        {
            if (Hash != null)
            {
                if (_MainWindow.CurrentNode != null)
                {
                    if (CurrentNode.Mem != _MainWindow.CurrentNode.Mem)
                    {
                        CurrentNode.DelNode(_MainWindow.NodeHash);
                        _MainWindow.UpdateGraphs();
                        ClearNode();
                    }
                }
                else
                {
                    CurrentNode.DelNode(_MainWindow.NodeHash);
                    _MainWindow.UpdateGraphs();
                    ClearNode();
                }
            }

        }

        private void DelBelow(object sender, RoutedEventArgs e)
        {
            if (Hash != null)
            {
                CurrentNode.DelBelow(_MainWindow.NodeHash);
                _MainWindow.UpdateCurrent();
                _MainWindow.UpdateGraphs();
                ClearNode();
            }
        }

        private void ClearNode()
        {
            Hash = null;
            NodeTag = null;
            NodeText = null;
            Stated = null;
        }

        private void AddUnder(object sender, RoutedEventArgs e)
        {
            if (Hash != null)
            {
                CurrentNode.AddParent(_MainWindow.CurrentNode);
                _MainWindow.CurrentNode.AddChild(CurrentNode);
                _MainWindow.UpdateGraphs();
            }
        }

        public void AddAbove()
        {
            if (Hash != null)
            {
                CurrentNode.AddChild(_MainWindow.CurrentNode);
                _MainWindow.CurrentNode.AddParent(CurrentNode);
                _MainWindow.UpdateGraphs();

            }
        }

        private string DolFolder = "";

        private void LoadState(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string StateDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @".."));
                string fileExtension = "*.txt";
                try
                {
                    string[] files = Directory.GetFiles(StateDirectory, fileExtension);
                    DolFolder = System.IO.File.ReadAllText(files[0]);
                }
                catch (Exception ex)
                {

                }



                string StartFile = "GSAE01.s10";
                string NewFile = button.Tag + ".sav";
                string NewFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..", "SaveStates"));

                string destinationFilePath = System.IO.Path.Combine(DolFolder, StartFile);
                string sourceFilePath = System.IO.Path.Combine(NewFolder, NewFile);

                try
                {
                    // Check if the source file exists
                    if (true)
                    {
                        // Copy the file from Folder A to Folder B with the new name
                        File.Copy(sourceFilePath, destinationFilePath, overwrite: true);

                        Debug.WriteLine($"File copied from {sourceFilePath} to {destinationFilePath} successfully.");
                    }

                }
                catch (Exception ex)
                {

                }
            }
        }



        bool Storing = false;
        private TreeNode? StoredNode = null;

        public void DelEdge(object sender, RoutedEventArgs e)
        {
            if (Hash != null)
            {

                if (Storing == true)
                {
                    if (StoredNode.Parents.Contains(CurrentNode))
                    {
                        StoredNode.RemParent(CurrentNode);
                        CurrentNode.RemChild(StoredNode);
                    }
                    if (StoredNode.Children.Contains(CurrentNode))
                    {
                        StoredNode.RemChild(CurrentNode);
                        CurrentNode.RemParent(StoredNode);
                    }
                    Storing = false;
                    EdgeButton.Background = Brushes.Transparent;
                    _MainWindow.UpdateGraphs();
                }

                else
                {
                    StoredNode = CurrentNode;
                    Storing = true;
                    EdgeButton.Background = Brushes.Red;

                }


            }
            else
            {
                Storing = false;
                EdgeButton.Background = Brushes.Transparent;
            }
        }

        private void MarkGoodUp(TreeNode Current)
        {
            Current.PracPath = true;
            if (Current.Parents.Count == 0)
            {

            }
            else
            {
                MarkGoodUp(Current.Parents[0]);
            }
        }

        public void UpGood()
        {
            if (Hash != null)
            {
                MarkGoodUp(CurrentNode);
                _MainWindow.UpdateCurrent();
                _MainWindow.UpdateGraphs();
            }
        }

        private void MarkBadDown(TreeNode Current)
        {
            Current.PracPath = false;
            if (Current.Children.Count == 0)
            {

            }
            else
            {
                MarkBadDown(Current.Children[0]);
            }
        }
        public void DownBad()
        {
            if (Hash != null)
            {
                MarkBadDown(CurrentNode);

                _MainWindow.UpdateCurrent();
                _MainWindow.UpdateGraphs();
            }
        }

        public void PracGood()
        {
            if (Hash != null)
            {
                CurrentNode.PracPath = true;
                _MainWindow.UpdateCurrent();
                _MainWindow.UpdateGraphs();
            }
        }

        public void PracBad()
        {
            if (Hash != null)
            {
                CurrentNode.PracPath = false;
                _MainWindow.UpdateCurrent();
                _MainWindow.UpdateGraphs();
            }
        }

        public void PracNeutral()
        {
            if (Hash != null)
            {
                CurrentNode.PracPath = null;
                _MainWindow.UpdateCurrent();
                _MainWindow.UpdateGraphs();
            }
        }

        private void IM(object sender, RoutedEventArgs e)
        {
            O1States.Visibility = Visibility.Visible;
            O2States.Visibility = Visibility.Collapsed;
            O3States.Visibility = Visibility.Collapsed;

            K5EB.Background = Brushes.LightGray;
            WCB.Background = Brushes.LightGray;

            IMB.Background = Brushes.DarkGray;
        }

        private void K5E(object sender, RoutedEventArgs e)
        {
            O1States.Visibility = Visibility.Collapsed;
            O2States.Visibility = Visibility.Visible;
            O3States.Visibility = Visibility.Collapsed;

            IMB.Background = Brushes.LightGray;
            WCB.Background = Brushes.LightGray;

            K5EB.Background = Brushes.DarkGray;

            
        }

        private void WC(object sender, RoutedEventArgs e)
        {
            O1States.Visibility = Visibility.Collapsed;
            O2States.Visibility = Visibility.Collapsed;
            O3States.Visibility = Visibility.Visible;

            IMB.Background = Brushes.LightGray;
            K5EB.Background = Brushes.LightGray;

            WCB.Background = Brushes.DarkGray;
        }
    }
}
