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
	/// Represents the DataRepository.ViewCauHinhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewCauHinhDataSourceDesigner))]
	public class ViewCauHinhDataSource : ReadOnlyDataSource<ViewCauHinh>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhDataSource class.
		/// </summary>
		public ViewCauHinhDataSource() : base(new ViewCauHinhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewCauHinhDataSourceView used by the ViewCauHinhDataSource.
		/// </summary>
		protected ViewCauHinhDataSourceView ViewCauHinhView
		{
			get { return ( View as ViewCauHinhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewCauHinhDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewCauHinhSelectMethod SelectMethod
		{
			get
			{
				ViewCauHinhSelectMethod selectMethod = ViewCauHinhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewCauHinhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewCauHinhDataSourceView class that is to be
		/// used by the ViewCauHinhDataSource.
		/// </summary>
		/// <returns>An instance of the ViewCauHinhDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewCauHinh, Object> GetNewDataSourceView()
		{
			return new ViewCauHinhDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewCauHinhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewCauHinhDataSourceView : ReadOnlyDataSourceView<ViewCauHinh>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewCauHinhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewCauHinhDataSourceView(ViewCauHinhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewCauHinhDataSource ViewCauHinhOwner
		{
			get { return Owner as ViewCauHinhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewCauHinhSelectMethod SelectMethod
		{
			get { return ViewCauHinhOwner.SelectMethod; }
			set { ViewCauHinhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewCauHinhService ViewCauHinhProvider
		{
			get { return Provider as ViewCauHinhService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewCauHinh> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewCauHinh> results = null;
			// ViewCauHinh item;
			count = 0;
			
			System.String sp931_SettingName;

			switch ( SelectMethod )
			{
				case ViewCauHinhSelectMethod.Get:
					results = ViewCauHinhProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewCauHinhSelectMethod.GetPaged:
					results = ViewCauHinhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewCauHinhSelectMethod.GetAll:
					results = ViewCauHinhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewCauHinhSelectMethod.Find:
					results = ViewCauHinhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewCauHinhSelectMethod.GetBySettingName:
					sp931_SettingName = (System.String) EntityUtil.ChangeType(values["SettingName"], typeof(System.String));
					results = ViewCauHinhProvider.GetBySettingName(sp931_SettingName, StartIndex, PageSize);
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

	#region ViewCauHinhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewCauHinhDataSource.SelectMethod property.
	/// </summary>
	public enum ViewCauHinhSelectMethod
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
		/// Represents the GetBySettingName method.
		/// </summary>
		GetBySettingName
	}
	
	#endregion ViewCauHinhSelectMethod
	
	#region ViewCauHinhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewCauHinhDataSource class.
	/// </summary>
	public class ViewCauHinhDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewCauHinh>
	{
		/// <summary>
		/// Initializes a new instance of the ViewCauHinhDataSourceDesigner class.
		/// </summary>
		public ViewCauHinhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewCauHinhSelectMethod SelectMethod
		{
			get { return ((ViewCauHinhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewCauHinhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewCauHinhDataSourceActionList

	/// <summary>
	/// Supports the ViewCauHinhDataSourceDesigner class.
	/// </summary>
	internal class ViewCauHinhDataSourceActionList : DesignerActionList
	{
		private ViewCauHinhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewCauHinhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewCauHinhDataSourceActionList(ViewCauHinhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewCauHinhSelectMethod SelectMethod
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

	#endregion ViewCauHinhDataSourceActionList

	#endregion ViewCauHinhDataSourceDesigner

	#region ViewCauHinhFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCauHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCauHinhFilter : SqlFilter<ViewCauHinhColumn>
	{
	}

	#endregion ViewCauHinhFilter

	#region ViewCauHinhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewCauHinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewCauHinhExpressionBuilder : SqlExpressionBuilder<ViewCauHinhColumn>
	{
	}
	
	#endregion ViewCauHinhExpressionBuilder		
}

