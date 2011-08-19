using System;

namespace Solyutor.Extex.ObjectActions
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this object self)
        {
            return ReferenceEquals(self, null);
        }

        public static bool IsNotNull(this object self)
        {
            return ReferenceEquals(self, null);
        }

        public static void DoIfNull(this object self, Action action)
        {
            if (self.IsNotNull()) return;
            action();
        }

        public static void DoIfNotNull(this object self, Action action)
        {
            if (self.IsNull()) return;
            action();
        }

        public static void DoIfNotNull<TObject>(this TObject self, Action<TObject> action)
        {
            if (self.IsNull()) return;
            action(self);
        }
    }
}