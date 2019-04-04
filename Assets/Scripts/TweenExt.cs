using DG.Tweening;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SKZ.Utils
{
    // https://gist.github.com/baba-s/6c393710ab5bd7acc946c0af2d0873d0#file-tweenext-cs
    public static class TweenExt
    {
        public static TaskAwaiter<Tween> GetAwaiter(this Tween self)
        {
            var source = new TaskCompletionSource<Tween>();

            TweenCallback onComplete = null;
            onComplete = () =>
            {
                self.onComplete -= onComplete;
                source.SetResult(self);
            };
            self.onComplete += onComplete;

            return source.Task.GetAwaiter();
        }
    }
}
