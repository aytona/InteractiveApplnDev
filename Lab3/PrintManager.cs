using System;

namespace Lab3 {
    class PrintManager {
        public String ID { get; set; }
        private static int _idNum = 0;
        private readonly int _id;
        private static PrintManager[] _instance = null;

        private PrintManager(int id) {
            this.ID = "Sheridan Print Manager";
            this._id = id;
        }

        public static PrintManager Instance {
            get {
                if (_instance == null) {
                    _instance = new PrintManager[3];
                }
                int current = _idNum;
                if (_instance[_idNum] == null) {
                    _instance[_idNum] = new PrintManager(_idNum);
                    if (_idNum + 1 < 3) {
                        _idNum++;
                    } else {
                        _idNum = 0;
                    }
                    return _instance[current];
                } else {
                    bool empty = false;
                    for (int i = 0; i < 3; ++i) {
                        if (_instance[i] == null) {
                            empty = true;
                            current = i;
                            break;
                        }
                    }
                    if (empty) {
                        _instance[current] = new PrintManager(current);
                        _idNum = current;
                        return _instance[current];
                    } else {
                        Random rnd = new Random((int)DateTime.UtcNow.Ticks);
                        return _instance[rnd.Next(0, 2)];
                    }
                }
            }
        }

        public String GetID() {
            return "Print ID Number: " + this._id;
        }
    }
}
