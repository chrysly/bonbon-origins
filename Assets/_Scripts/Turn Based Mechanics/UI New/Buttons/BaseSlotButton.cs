﻿namespace BattleUI {
    public abstract class BaseSlotButton<T> : UIButtonBase<T> where T : UIStateHandler {
        public int Slot { get; private set; }
        public virtual void Init(int slot) => Slot = slot;
    }
}