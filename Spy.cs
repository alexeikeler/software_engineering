using System.Collections.Generic;

namespace StOPatterns
{
    public class Spy: ISubject
    {
        private MoveAt45 _moveAt45;
        private MoveStraight _moveStraight;
        private MaskAtOdd _maskAtOdd;
        private MaskAtEven _maskAtEven;
        private List<IObserver> obs;

        public Point _currentPoint { get; }
        public bool masked { get; private set; }
        
        public Spy()
        {
            obs = new List<IObserver>();
            _currentPoint = new Point(4, 4); 
            _moveAt45 = new MoveAt45();
            _moveStraight = new MoveStraight();
            _maskAtOdd = new MaskAtOdd();
            _maskAtEven = new MaskAtEven();
        }
        
        public void RemoveObserver(IObserver o)
        {
            obs.Remove(o);
        }

        public void AddObserver(IObserver o)
        {
            obs.Add(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in obs)
            {
                o.Update(_currentPoint, masked);
            }
        }
        
        public void MoveHow(int number)
        {
            int dest;
            
            if (number > 10)
            {
                masked = _maskAtEven.Mask(_currentPoint);
            }
            else if (number < 10)
            {
                masked = _maskAtOdd.Mask(_currentPoint);
            }
            
            if (number % 2 == 0)
            {
                dest = _moveAt45.pick_random();
                _moveAt45.Move(dest, _currentPoint);
            }
            else
            {
                dest = _moveStraight.pick_random();
                _moveStraight.Move(dest, _currentPoint);
            }

            NotifyObservers();
        }

    }
}