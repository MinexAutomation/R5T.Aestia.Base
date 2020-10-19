﻿using System;
using System.Collections.Generic;
using System.Linq;

using R5T.Corcyra;
using R5T.Francia;
using R5T.Sindia;
using R5T.Siscia;


namespace R5T.Aestia
{
    public class AnomalyInfo
    {
        public AnomalyIdentity AnomalyIdentity { get; set; }
        public DateTime ReportedUTC { get; set; }
        public List<CatchmentIdentity> CatchmentIdentities { get; set; }
        public List<ImageFileIdentity> ImageFileIdentities { get; set; }
        public LocationIdentity ReportedLocation { get; set; }
        public LocationIdentity ReporterLocation { get; set; }
        public List<TextItemIdentity> TextItems { get; set; }

        public bool HasCatchment => this.CatchmentIdentities.Any();
        public bool HasReportedLocation => this.ReportedLocation is object;
        public bool HasReporterLocation => this.ReporterLocation is object;
    }
}
