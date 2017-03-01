#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.ViewChiTietHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewChiTietHocPhanDataSourceDesigner))]
	public class ViewChiTietHocPhanDataSource : ReadOnlyDataSource<ViewChiTietHocPhan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietHocPhanDataSource class.
		/// </summary>
		public ViewChiTietHocPhanDataSource() : base(new ViewChiTietHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewChiTietHocPhanDataSourceView used by the ViewChiTietHocPhanDataSource.
		/// </summary>
		protected ViewChiTietHocPhanDataSourceView ViewChiTietHocPhanView
		{
			get { return ( View as ViewChiTietHocPhanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewChiTietHocPhanDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewChiTietHocPhanSelectMethod SelectMethod
		{
			get
			{
				ViewChiTietHocPhanSelectMethod selectMethod = ViewChiTietHocPhanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewChiTietHocPhanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewChiTietHocPhanDataSourceView class that is to be
		/// used by the ViewChiTietHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewChiTietHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewChiTietHocPhan, Object> GetNewDataSourceView()
		{
			return new ViewChiTietHocPhanDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the ViewChiTietHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewChiTietHocPhanDataSourceView : ReadOnlyDataSourceView<ViewChiTietHocPhan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewChiTietHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewChiTietHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewChiTietHocPhanDataSourceView(ViewChiTietHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewChiTietHocPhanDataSource ViewChiTietHocPhanOwner
		{
			get { return Owner as ViewChiTietHocPhanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewChiTietHocPhanSelectMethod SelectMethod
		{
			get { return ViewChiTietHocPhanOwner.SelectMethod; }
			set { ViewChiTietHocPhanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewChiTietHocPhanService ViewChiTietHocPhanProvider
		{
			get { return Provider as ViewChiTietHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewChiTietHocPhan> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewChiTietHocPhan> results = null;
			// ViewChiTietHocPhan item;
			count = 0;
			
			System.String sp936_MaGiangVien;
			System.String sp936_MaLopHocPhan;
			System.String sp936_MaLop;
			System.String sp937_MaLopHocPhan;

			switch ( SelectMethod )
			{
				case ViewChiTietHocPhanSelectMethod.Get:
					results = ViewChiTietHocPhanProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewChiTietHocPhanSelectMethod.GetPaged:
					results = ViewChiTietHocPhanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewChiTietHocPhanSelectMethod.GetAll:
					results = ViewChiTietHocPhanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewChiTietHocPhanSelectMethod.Find:
					results = ViewChiTietHocPhanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewChiTietHocPhanSelectMethod.GetByMaGiangVienMaLopHocPhanMaLop:
					sp936_MaGiangVien = (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String));
					sp936_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					sp936_MaLop = (System.String) EntityUtil.ChangeType(values["MaLop"], typeof(System.String));
					results = ViewChiTietHocPhanProvider.GetByMaGiangVienMaLopHocPhanMaLop(sp936_MaGiangVien, sp936_MaLopHocPhan, sp936_MaLop, StartIndex, PageSize);
					break;
				case ViewChiTietHocPhanSelectMethod.GetByMaLopHocPhan:
					sp937_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					results = ViewChiTietHocPhanProvider.GetByMaLopHocPhan(sp937_MaLopHocPhan, StartIndex, PageSize);
					break;
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;
				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}				
			}
			
			return results;
		}
		
		#endregion Methods
	}

	#region ViewChiTietHocPhanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewChiTietHocPhanDataSource.SelectMethod property.
	/// </summary>
	public enum ViewChiTietHocPhanSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaGiangVienMaLopHocPhanMaLop method.
		/// </summary>
		GetByMaGiangVienMaLopHocPhanMaLop,
		/// <summary>
		/// Represents the GetByMaLopHocPhan method.
		/// </summary>
		GetByMaLopHocPhan
	}
	
	#endregion ViewChiTietHocPhanSelectMethod
	
	#region ViewChiTietHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewChiTietHocPhanDataSource class.
	/// </summary>
	public class ViewChiTietHocPhanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewChiTietHocPhan>
	{
		/// <summary>
		/// Initializes a new instance of the ViewChiTietHocPhanDataSourceDesigner class.
		/// </summary>
		public ViewChiTietHocPhanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewChiTietHocPhanSelectMethod SelectMethod
		{
			get { return ((ViewChiTietHocPhanDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new ViewChiTietHocPhanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewChiTietHocPhanDataSourceActionList

	/// <summary>
	/// Supports the ViewChiTietHocPhanDataSourceDesigner class.
	/// </summary>
	internal class ViewChiTietHocPhanDataSourceActionList : DesignerActionList
	{
		private ViewChiTietHocPhanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewChiTietHocPhanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewChiTietHocPhanDataSourceActionList(ViewChiTietHocPhanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewChiTietHocPhanSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion ViewChiTietHocPhanDataSourceActionList

	#endregion ViewChiTietHocPhanDataSourceDesigner

	#region ViewChiTietHocPhanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietHocPhanFilter : SqlFilter<ViewChiTietHocPhanColumn>
	{
	}

	#endregion ViewChiTietHocPhanFilter

	#region ViewChiTietHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewChiTietHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewChiTietHocPhanExpressionBuilder : SqlExpressionBuilder<ViewChiTietHocPhanColumn>
	{
	}
	
	#endregion ViewChiTietHocPhanExpressionBuilder		
}

