using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Calendar;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Repository;

namespace MonthYearDateEdit
{
	public class MonthYearEdit : DateEdit
	{
		public MonthYearEdit()
		{
			Properties.Mask.EditMask = "y";
		}

		protected override PopupBaseForm CreatePopupForm()
		{
			return new YearMonthVistaPopupDateEditForm(this);
		}

		protected override void CreateRepositoryItem()
		{
			fProperties = new YearMonthRepositoryItemDateEdit(this);
		}

		class YearMonthRepositoryItemDateEdit : RepositoryItemDateEdit
		{
			public YearMonthRepositoryItemDateEdit(DateEdit dateEdit)
			{
				SetOwnerEdit(dateEdit);
			}

			[Browsable(false)]
			public override bool ShowToday
			{
				get
				{
					return false;
				}
			}
		}

		class YearMonthVistaPopupDateEditForm : VistaPopupDateEditForm
		{
			public YearMonthVistaPopupDateEditForm(DateEdit ownerEdit)
				: base(ownerEdit) { }

			protected override DateEditCalendar CreateCalendar()
			{
				return new YearMonthVistaDateEditCalendar(OwnerEdit.Properties, OwnerEdit.EditValue);
			}
		}

		class YearMonthVistaDateEditCalendar : VistaDateEditCalendar
		{
			public YearMonthVistaDateEditCalendar(RepositoryItemDateEdit item, object editDate)
				: base(item, editDate) { }

			protected override void Init()
			{
				base.Init();
				View = DateEditCalendarViewType.YearInfo;
			}

			protected override void OnItemClick(CalendarHitInfo hitInfo)
			{
				DayNumberCellInfo cell = (DayNumberCellInfo)hitInfo.HitObject;

				if (View == DateEditCalendarViewType.YearInfo)
				{
					DateTime date = new DateTime(DateTime.Year, cell.Date.Month, 1);
					OnDateTimeCommit(date, false);
				}
				else
				{
					base.OnItemClick(hitInfo);
				}
			}
		}
	}
}
