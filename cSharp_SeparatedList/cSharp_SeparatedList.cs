using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class cSharp_SeparatedList
{
    #region "Private Variables"
        //*******************************************************************************************************************************
        //* Private variables                                                                                                           *
        //*******************************************************************************************************************************
        private Char _separator;
        private List<String> _entries;
        private List<Char> _unusedSeparators;
    #endregion

    #region "Public Variables"
        //*******************************************************************************************************************************
        //* Public variables                                                                                                            *
        //*******************************************************************************************************************************
        public static List<Char> InvalidSeparatorCharacters = new List<char>(Convert.ToChar(0) + Environment.NewLine);
        public static List<Char> ValidSeparatorCharacters;
    #endregion

    #region "Public Properties"
        //*******************************************************************************************************************************
        //* Public properties                                                                                                           *
        //*******************************************************************************************************************************
        public List<string> Entries
        {
            get { return this._entries; }
        }

        public Char Separator
        {
            get { return this._separator; }
            set { this._separator = value; }
        }

        public List<char> UnusedSeparators
        {
            get { return this._unusedSeparators; }
        }
    #endregion

    #region "Static Methods"
        //*******************************************************************************************************************************
        //* Static methods                                                                                                              *
        //*******************************************************************************************************************************
        static cSharp_SeparatedList()
        {
            // Initialise a list of all available separator characters
            ValidSeparatorCharacters = new List<Char> {};

            for (Int16 charCode = 0; charCode < 256; charCode++)
            {
                Char currentCharacter = Convert.ToChar(charCode);

                if (!InvalidSeparatorCharacters.Contains(currentCharacter))
                {
                    ValidSeparatorCharacters.Add(currentCharacter);
                }
            }
        }
    #endregion

    #region "Public methods"
        //*******************************************************************************************************************************
        //* Public methods                                                                                                              *
        //*******************************************************************************************************************************
        public cSharp_SeparatedList(String fromString)
        {
            // Initialise the separator value
            if (fromString.Length > 0)
            {
                this._separator = Convert.ToChar(fromString.Substring(0, 1));
            }
            else
            {
                this._separator = Convert.ToChar(String.Empty);
            }

            // Split the string into a list using the extracted separator
            if (fromString.Length > 1)
            {
                this._entries = new List<String>(fromString.Substring(1).Split(_separator));
            }
            else
            {
                this._entries = new List<String> { };
            }

            this._unusedSeparators = new List<Char> { };
        }

        public cSharp_SeparatedList(Char separator, params String[] entries)
        {
            // Initialise the separator value and list using the values specified
            this._separator = separator;
            this._entries = new List<String>(entries);
            this._unusedSeparators = new List<Char> { };
        }

        public cSharp_SeparatedList(Char[] separators, params String[] entries)
        {
            // Add any initial entries to the list
            this._entries = new List<String>(entries);

            if (separators.Length == 1)
            {
                // Choose the single separator character specified
                this._separator = separators[0];
            }
            else if (separators.Length > 1)
            {
                // Choose the next unused separator from the values specified
                _findNextNotUsedSeparator(separators);
            }
            else
            {
                // Choose the next unused separator from the list of all available valid separators
                _findNextNotUsedSeparator(cSharp_SeparatedList.ValidSeparatorCharacters.ToArray());
            }
        }

        public override String ToString()
        {
            return this.Separator.ToString() + String.Join(this.Separator.ToString(), this.Entries);
        }
    #endregion


    #region "Private methods"
        //*******************************************************************************************************************************
        //* Private methods                                                                                                             *
        //*******************************************************************************************************************************
        private void _findNextNotUsedSeparator(Char[] separators)
        {
            String searchString = String.Join(String.Empty, _entries);
            this._unusedSeparators = new List<Char> {};
            Boolean found = false;

            foreach (Char separator in separators)
            {
                if (!found)
                {
                    if (!searchString.Contains(separator))
                    {
                        this._separator = separator;
                        found = true;
                    }
                } else {
                    this._unusedSeparators.Add(separator);
                }
            }
        }
    #endregion
}
