using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DiffieHellman
{
    class viewmodel : INotifyPropertyChanged
    {
        private int _g;

        public int G
        {
            get { return _g; }
            set { _g = value;
                propChanged(nameof(G));
                propChanged(nameof(A));
                propChanged(nameof(B));
                propChanged(nameof(sa));
                propChanged(nameof(sb));
            }
        }
        private int _p;

        public int p
        {
            get { return _p; }
            set { _p = value;
                propChanged(nameof(p));
                propChanged(nameof(A));
                propChanged(nameof(B));
                propChanged(nameof(sa));
                propChanged(nameof(sb));
            }
        }

       
        public int A
        {
            get
            {
                return (int)(Math.Pow(G, a) % p)  ;
            }
            
        }

        public int B
        {
            get { return (int)(Math.Pow(G, b) % p); }
            
        }

        private int _a;
        public int a
        {
            get { return _a; }
            set { _a = value;
                propChanged();
                propChanged(nameof(A));
                propChanged(nameof(B));
                propChanged(nameof(sa));
                propChanged(nameof(sb));
            }
        }

        private int _b;
        public int b
        {
            get { return _b; }
            set { _b = value;
                propChanged(nameof(b));
                propChanged(nameof(A));
                propChanged(nameof(B));
                propChanged(nameof(sa));
                propChanged(nameof(sb));

            }
        }
       
        public int sa
        {
            get { return  (int)(Math.Pow(B,a)%p); }
            
        }
       

        public int sb
        {
            get { return (int)(Math.Pow(A, b) % p); }

        }

        public viewmodel()
        {
            p = 23;
            G = 5;
            a = 6;
            b = 15;
        }
        
        #region inotify
        public event PropertyChangedEventHandler PropertyChanged;
        private void propChanged([CallerMemberName] string name="")
        {
            if (PropertyChanged!= null)
             PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion

    }

}
