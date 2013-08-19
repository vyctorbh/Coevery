﻿using System.Collections.Generic;
using Orchard.Autoroute.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using Orchard.Core.Title.Models;

namespace Coevery.Taxonomies.Models {
    public class TaxonomyPart : ContentPart<TaxonomyPartRecord> {
        internal LazyField<IEnumerable<TermPart>> TermsField = new LazyField<IEnumerable<TermPart>>();
        public IEnumerable<TermPart> Terms { get { return TermsField.Value; } }

        public string Name {
            get { return this.As<TitlePart>().Title; }
            set { this.As<TitlePart>().Title = value; }
        }

        public string Slug {
            get { return this.As<AutoroutePart>().DisplayAlias; }
            set { this.As<AutoroutePart>().DisplayAlias = value; }
        }

        public string TermTypeName {
            get { return Record.TermTypeName; }
            set { Record.TermTypeName = value; }
        }

        public bool IsInternal {
            get { return Record.IsInternal; }
            set { Record.IsInternal = value; }
        }

    }
}
