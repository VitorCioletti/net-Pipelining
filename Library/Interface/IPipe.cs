﻿namespace PipeliningLibrary
{
    using System;

    /// <summary>
    /// Pipe that can be chained into a pipeline.
    /// </summary>
    public interface IPipe
    {
        /// <summary>
        /// Runs this pipe.
        /// </summary>
        /// <param name="input">Pipe's input</param>
        /// <param name="progress">Action to call for progress messages</param>
        /// <returns>Output of the run</returns>
        object Run(dynamic input, Action<string> progress);
    }
}
