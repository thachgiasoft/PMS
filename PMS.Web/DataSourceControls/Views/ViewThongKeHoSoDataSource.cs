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
	/// Represents the DataRepository.ViewThongKeHoSoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThongKeHoSoDataSourceDesigner))]
	public class ViewThongKeHoSoDataSource : ReadOnlyDataSource<ViewThongKeHoSo>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoDataSource class.
		/// </summary>
		public ViewThongKeHoSoDataSource() : base(new ViewThongKeHoSoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThongKeHoSoDataSourceView used by the ViewThongKeHoSoDataSource.
		/// </summary>
		protected ViewThongKeHoSoDataSourceView ViewThongKeHoSoView
		{
			get { return ( View as ViewThongKeHoSoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThongKeHoSoDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThongKeHoSoSelectMethod SelectMethod
		{
			get
			{
				ViewThongKeHoSoSelectMethod selectMethod = ViewThongKeHoSoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThongKeHoSoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThongKeHoSoDataSourceView class that is to be
		/// used by the ViewThongKeHoSoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThongKeHoSoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThongKeHoSo, Object> GetNewDataSourceView()
		{
			return new ViewThongKeHoSoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThongKeHoSoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThongKeHoSoDataSourceView : ReadOnlyDataSourceView<ViewThongKeHoSo>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThongKeHoSoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThongKeHoSoDataSourceView(ViewThongKeHoSoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThongKeHoSoDataSource ViewThongKeHoSoOwner
		{
			get { return Owner as ViewThongKeHoSoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThongKeHoSoSelectMethod SelectMethod
		{
			get { return ViewThongKeHoSoOwner.SelectMethod; }
			set { ViewThongKeHoSoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThongKeHoSoService ViewThongKeHoSoProvider
		{
			get { return Provider as ViewThongKeHoSoService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThongKeHoSo> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThongKeHoSo> results = null;
			// ViewThongKeHoSo item;
			count = 0;
			
			System.String sp1112_MaTuyChon;

			switch ( SelectMethod )
			{
				case ViewThongKeHoSoSelectMethod.Get:
					results = ViewThongKeHoSoProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThongKeHoSoSelectMethod.GetPaged:
					results = ViewThongKeHoSoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThongKeHoSoSelectMethod.GetAll:
					results = ViewThongKeHoSoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThongKeHoSoSelectMethod.Find:
					results = ViewThongKeHoSoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThongKeHoSoSelectMethod.GetByNopDu:
					sp1112_MaTuyChon = (System.String) EntityUtil.ChangeType(values["MaTuyChon"], typeof(System.String));
					results = ViewThongKeHoSoProvider.GetByNopDu(sp1112_MaTuyChon, StartIndex, PageSize);
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

	#region ViewThongKeHoSoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThongKeHoSoDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThongKeHoSoSelectMethod
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
		/// Represents the GetByNopDu method.
		/// </summary>
		GetByNopDu
	}
	
	#endregion ViewThongKeHoSoSelectMethod
	
	#region ViewThongKeHoSoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThongKeHoSoDataSource class.
	/// </summary>
	public class ViewThongKeHoSoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThongKeHoSo>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoDataSourceDesigner class.
		/// </summary>
		public ViewThongKeHoSoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThongKeHoSoSelectMethod SelectMethod
		{
			get { return ((ViewThongKeHoSoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThongKeHoSoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThongKeHoSoDataSourceActionList

	/// <summary>
	/// Supports the ViewThongKeHoSoDataSourceDesigner class.
	/// </summary>
	internal class ViewThongKeHoSoDataSourceActionList : DesignerActionList
	{
		private ViewThongKeHoSoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThongKeHoSoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThongKeHoSoDataSourceActionList(ViewThongKeHoSoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThongKeHoSoSelectMethod SelectMethod
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

	#endregion ViewThongKeHoSoDataSourceActionList

	#endregion ViewThongKeHoSoDataSourceDesigner

	#region ViewThongKeHoSoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeHoSoFilter : SqlFilter<ViewThongKeHoSoColumn>
	{
	}

	#endregion ViewThongKeHoSoFilter

	#region ViewThongKeHoSoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThongKeHoSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThongKeHoSoExpressionBuilder : SqlExpressionBuilder<ViewThongKeHoSoColumn>
	{
	}
	
	#endregion ViewThongKeHoSoExpressionBuilder		
}

