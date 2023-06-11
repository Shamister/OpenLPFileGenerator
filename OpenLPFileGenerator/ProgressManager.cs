namespace OpenLPFileGenerator
{
    public class ProgressManager
    {
        private ProgressBar _progressBar;

        private double _value;

        public double Value
        {
            get
            {
                return _value;
            }
        }

        public ProgressManager(ProgressBar progressBar)
        {
            _progressBar = progressBar;
        }

        public void Start()
        {
            if (_progressBar.InvokeRequired)
            {
                _progressBar.BeginInvoke(new MethodInvoker(delegate { InvokeStart(); }));
            }
            else
            {
                InvokeStart();
            }
        }

        public void Complete()
        {
            if (_progressBar.InvokeRequired)
            {
                _progressBar.BeginInvoke(new MethodInvoker(delegate { InvokeComplete(); }));
            }
            else
            {
                InvokeComplete();
            }
        }

        public void IncreaseValue(double value)
        {
            if (_progressBar.InvokeRequired)
            {
                _progressBar.BeginInvoke(new MethodInvoker(delegate { InvokeIncreaseValue(value); }));
            }
            else
            {
                InvokeIncreaseValue(value);
            }
        }

        public void InvokeIncreaseValue(double value)
        {
            _value += value;
            _progressBar.Increment(Convert.ToInt32(Math.Round(_value)) - _progressBar.Value);
        }

        public void InvokeStart()
        {
            _progressBar.Value = 0;
            _progressBar.Visible = true;
        }

        public void InvokeComplete()
        {
            _progressBar.Increment(_progressBar.Maximum - _progressBar.Value);
            _progressBar.Visible = false;
        }
    }
}
