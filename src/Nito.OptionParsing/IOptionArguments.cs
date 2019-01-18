﻿namespace Nito.OptionParsing
{
    /// <summary>
    /// An arguments class, which uses option attributes on its properties.
    /// </summary>
    public interface IOptionArguments
    {
        /// <summary>
        /// Validates the arguments by throwing <see cref="OptionParsingException"/> errors as necessary.
        /// </summary>
        void Validate();
    }
}
