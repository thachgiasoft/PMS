#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.NgonNguGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(NgonNguGiangDayDataSourceDesigner))]
	public class NgonNguGiangDayDataSource : ProviderDataSource<NgonNguGiangDay, NgonNguGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NgonNguGiangDayDataSource class.
		/// </summary>
		public NgonNguGiangDayDataSource() : base(new NgonNguGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the NgonNguGiangDayDataSourceView used by the NgonNguGiangDayDataSource.
		/// </summary>
		protected NgonNguGiangDayDataSourceView NgonNguGiangDayView
		{
			get { return ( View as NgonNguGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the NgonNguGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public NgonNguGiangDaySelectMethod SelectMethod
		{
			get
			{
				NgonNguGiangDaySelectMethod selectMethod = NgonNguGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (NgonNguGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the NgonNguGiangDayDataSourceView class that is to be
		/// used by the NgonNguGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the NgonNguGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<NgonNguGiangDay, NgonNguGiangDayKey> GetNewDataSourceView()
		{
			return new NgonNguGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the NgonNguGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class NgonNguGiangDayDataSourceView : ProviderDataSourceView<NgonNguGiangDay, NgonNguGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NgonNguGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the NgonNguGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public NgonNguGiangDayDataSourceView(NgonNguGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal NgonNguGiangDayDataSource NgonNguGiangDayOwner
		{
			get { return Owner as NgonNguGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal NgonNguGiangDaySelectMethod SelectMethod
		{
			get { return NgonNguGiangDayOwner.SelectMethod; }
			set { NgonNguGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal NgonNguGiangDayService NgonNguGiangDayProvider
		{
			get { return Provider as NgonNguGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<NgonNguGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<NgonNguGiangDay> results = null;
			NgonNguGiangDay item;
			count = 0;
			
			System.String _maNgonNgu;

			switch ( SelectMethod )
			{
				case NgonNguGiangDaySelectMethod.Get:
					NgonNguGiangDayKey entityKey  = new NgonNguGiangDayKey();
					entityKey.Load(values);
					item = NgonNguGiangDayProvider.Get(entityKey);
					results = new TList<NgonNguGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case NgonNguGiangDaySelectMethod.GetAll:
                    results = NgonNguGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case NgonNguGiangDaySelectMethod.GetPaged:
					results = NgonNguGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case NgonNguGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = NgonNguGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = NgonNguGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case NgonNguGiangDaySelectMethod.GetByMaNgonNgu:
					_maNgonNgu = ( values["MaNgonNgu"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaNgonNgu"], typeof(System.String)) : string.Empty;
					item = NgonNguGiangDayProvider.GetByMaNgonNgu(_maNgonNgu);
					results = new TList<NgonNguGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
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
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == NgonNguGiangDaySelectMethod.Get || SelectMethod == NgonNguGiangDaySelectMethod.GetByMaNgonNgu )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				NgonNguGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					NgonNguGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<NgonNguGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			NgonNguGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region NgonNguGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the NgonNguGiangDayDataSource class.
	/// </summary>
	public class NgonNguGiangDayDataSourceDesigner : ProviderDataSourceDesigner<NgonNguGiangDay, NgonNguGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the NgonNguGiangDayDataSourceDesigner class.
		/// </summary>
		public NgonNguGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NgonNguGiangDaySelectMethod SelectMethod
		{
			get { return ((NgonNguGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new NgonNguGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region NgonNguGiangDayDataSourceActionList

	/// <summary>
	/// Supports the NgonNguGiangDayDataSourceDesigner class.
	/// </summary>
	internal class NgonNguGiangDayDataSourceActionList : DesignerActionList
	{
		private NgonNguGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the NgonNguGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public NgonNguGiangDayDataSourceActionList(NgonNguGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NgonNguGiangDaySelectMethod SelectMethod
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

	#endregion NgonNguGiangDayDataSourceActionList
	
	#endregion NgonNguGiangDayDataSourceDesigner
	
	#region NgonNguGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the NgonNguGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum NgonNguGiangDaySelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaNgonNgu method.
		/// </summary>
		GetByMaNgonNgu
	}
	
	#endregion NgonNguGiangDaySelectMethod

	#region NgonNguGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NgonNguGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NgonNguGiangDayFilter : SqlFilter<NgonNguGiangDayColumn>
	{
	}
	
	#endregion NgonNguGiangDayFilter

	#region NgonNguGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NgonNguGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NgonNguGiangDayExpressionBuilder : SqlExpressionBuilder<NgonNguGiangDayColumn>
	{
	}
	
	#endregion NgonNguGiangDayExpressionBuilder	

	#region NgonNguGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;NgonNguGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="NgonNguGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NgonNguGiangDayProperty : ChildEntityProperty<NgonNguGiangDayChildEntityTypes>
	{
	}
	
	#endregion NgonNguGiangDayProperty
}

