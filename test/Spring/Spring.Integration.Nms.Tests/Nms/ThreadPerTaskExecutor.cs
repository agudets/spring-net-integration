#region License

/*
 * Copyright 2002-2010 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using System;
using System.Threading;
using Spring.Threading;

namespace Spring.Integration.Nms
{
    /// <summary>
    ///  
    /// </summary>
    /// <author>Mark Pollack</author>
    public class ThreadPerTaskExecutor : IExecutor
    {
        public void Execute(IRunnable r)
        {
            new Thread(new ThreadStart(r.Run)).Start();
        }

        public void Execute(Action action)
        {
            new Thread(new ThreadStart(action)).Start();
        }

    }

}