﻿using Com.Moonlay.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Com.Danliris.Service.Finishing.Printing.Lib.Models.ShipmentDocument
{
    public class ShipmentDocumentItemModel : StandardEntity, IValidatableObject
    {
        [MaxLength(250)]
        public string PackingReceiptCode { get; set; }
        public int PackingReceiptId { get; set; }
        public ICollection<ShipmentDocumentPackingReceiptItemModel> PackingReceiptItems { get; set; }
        [MaxLength(250)]
        public string ReferenceNo { get; set; }
        [MaxLength(250)]
        public string ReferenceType { get; set; }
        public int ShipmentDocumentDetailId { get; set; }
        [ForeignKey("ShipmentDocumentDetailId")]
        public virtual ShipmentDocumentDetailModel ShipmentDocumentDetail { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
        }
    }
}
