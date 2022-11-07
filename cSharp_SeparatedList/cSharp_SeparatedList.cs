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
        private Char _Separator;
        private List<String> _Entries;
        private List<Char> _UnusedSeparators;
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
            get { return this._Entries; }
        }

        public Char Separator
        {
            get { return this._Separator; }
            set { this._Separator = value; }
        }

        public List<char> UnusedSeparators
        {
            get { return this._UnusedSeparators; }
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

            for (Int16 CharCode = 0; CharCode < 256; CharCode++)
            {
                Char CurrentCharacter = Convert.ToChar(CharCode);

                if (!InvalidSeparatorCharacters.Contains(CurrentCharacter))
                {
                    ValidSeparatorCharacters.Add(CurrentCharacter);
                }
            }
        }
    #endregion

    #region "Public methods"
        //*******************************************************************************************************************************
        //* Public methods                                                                                                              *
        //*******************************************************************************************************************************
        public cSharp_SeparatedList(String FromString)
        {
            // Initialise the separator value
            if (FromString.Length > 0)
            {
                this._Separator = Convert.ToChar(FromString.Substring(0, 1));
            }
            else
            {
                this._Separator = Convert.ToChar(String.Empty);
            }

            // Split the string into a list using the extracted separator
            if (FromString.Length > 1)
            {
                this._Entries = new List<String>(FromString.Substring(1).Split(_Separator));
            }
            else
            {
                this._Entries = new List<String> { };
            }

            this._UnusedSeparators = new List<Char> { };
        }

        public cSharp_SeparatedList(Char Separator, params String[] Entries)
        {
            // Initialise the separator value and list using the values specified
            this._Separator = Separator;
            this._Entries = new List<String>(Entries);
            this._UnusedSeparators = new List<Char> { };
        }

        public cSharp_SeparatedList(Char[] Separators, params String[] Entries)
        {
            // Add any initial entries to the list
            this._Entries = new List<String>(Entries);

            if (Separators.Length == 1)
            {
                // Choose the single separator character specified
                this._Separator = Separators[0];
            }
            else if (Separators.Length > 1)
            {
                // Choose the next unused separator from the values specified
                _FindNextNotUsedSeparator(Separators);
            }
            else
            {
                // Choose the next unused separator from the list of all available valid separators
                _FindNextNotUsedSeparator(cSharp_SeparatedList.ValidSeparatorCharacters.ToArray());
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
        private void _FindNextNotUsedSeparator(Char[] Separators)
        {
            String SearchString = String.Join(String.Empty, _Entries);
            this._UnusedSeparators = new List<Char> { };
            Boolean found = false;

            foreach (Char Separator in Separators)
            {
                if (!found)
                {
                    if (!SearchString.Contains(Separator))
                    {
                        this._Separator = Separator;
                        found = true;
                    }
                } else {
                    this._UnusedSeparators.Add(Separator);
                }
            }
        }
    #endregion
}
