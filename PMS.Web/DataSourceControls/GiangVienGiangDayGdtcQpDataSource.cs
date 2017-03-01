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
	/// Represents the DataRepository.GiangVienGiangDayGdtcQpProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienGiangDayGdtcQpDataSourceDesigner))]
	public class GiangVienGiangDayGdtcQpDataSource : ProviderDataSource<GiangVienGiangDayGdtcQp, GiangVienGiangDayGdtcQpKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienGiangDayGdtcQpDataSource class.
		/// </summary>
		public GiangVienGiangDayGdtcQpDataSource() : base(new GiangVienGiangDayGdtcQpService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienGiangDayGdtcQpDataSourceView used by the GiangVienGiangDayGdtcQpDataSource.
		/// </summary>
		protected GiangVienGiangDayGdtcQpDataSourceView GiangVienGiangDayGdtcQpView
		{
			get { return ( View as GiangVienGiangDayGdtcQpDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienGiangDayGdtcQpDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienGiangDayGdtcQpSelectMethod SelectMethod
		{
			get
			{
				GiangVienGiangDayGdtcQpSelectMethod selectMethod = GiangVienGiangDayGdtcQpSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienGiangDayGdtcQpSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienGiangDayGdtcQpDataSourceView class that is to be
		/// used by the GiangVienGiangDayGdtcQpDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienGiangDayGdtcQpDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienGiangDayGdtcQp, GiangVienGiangDayGdtcQpKey> GetNewDataSourceView()
		{
			return new GiangVienGiangDayGdtcQpDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienGiangDayGdtcQpDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienGiangDayGdtcQpDataSourceView : ProviderDataSourceView<GiangVienGiangDayGdtcQp, GiangVienGiangDayGdtcQpKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienGiangDayGdtcQpDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienGiangDayGdtcQpDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienGiangDayGdtcQpDataSourceView(GiangVienGiangDayGdtcQpDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienGiangDayGdtcQpDataSource GiangVienGiangDayGdtcQpOwner
		{
			get { return Owner as GiangVienGiangDayGdtcQpDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienGiangDayGdtcQpSelectMethod SelectMethod
		{
			get { return GiangVienGiangDayGdtcQpOwner.SelectMethod; }
			set { GiangVienGiangDayGdtcQpOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienGiangDayGdtcQpService GiangVienGiangDayGdtcQpProvider
		{
			get { return Provider as GiangVienGiangDayGdtcQpService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienGiangDayGdtcQp> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienGiangDayGdtcQp> results = null;
			GiangVienGiangDayGdtcQp item;
			count = 0;
			
			System.Int32 _maQuanLy;

			switch ( SelectMethod )
			{
				case GiangVienGiangDayGdtcQpSelectMethod.Get:
					GiangVienGiangDayGdtcQpKey entityKey  = new GiangVienGiangDayGdtcQpKey();
					entityKey.Load(values);
					item = GiangVienGiangDayGdtcQpProvider.Get(entityKey);
					results = new TList<GiangVienGiangDayGdtcQp>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienGiangDayGdtcQpSelectMethod.GetAll:
                    results = GiangVienGiangDayGdtcQpProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienGiangDayGdtcQpSelectMethod.GetPaged:
					results = GiangVienGiangDayGdtcQpProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienGiangDayGdtcQpSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienGiangDayGdtcQpProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienGiangDayGdtcQpProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienGiangDayGdtcQpSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.Int32)) : (int)0;
					item = GiangVienGiangDayGdtcQpProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<GiangVienGiangDayGdtcQp>();
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
			if ( SelectMethod == GiangVienGiangDayGdtcQpSelectMethod.Get || SelectMethod == GiangVienGiangDayGdtcQpSelectMethod.GetByMaQuanLy )
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
				GiangVienGiangDayGdtcQp entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienGiangDayGdtcQpProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienGiangDayGdtcQp> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienGiangDayGdtcQpProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienGiangDayGdtcQpDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienGiangDayGdtcQpDataSource class.
	/// </summary>
	public class GiangVienGiangDayGdtcQpDataSourceDesigner : ProviderDataSourceDesigner<GiangVienGiangDayGdtcQp, GiangVienGiangDayGdtcQpKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienGiangDayGdtcQpDataSourceDesigner class.
		/// </summary>
		public GiangVienGiangDayGdtcQpDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienGiangDayGdtcQpSelectMethod SelectMethod
		{
			get { return ((GiangVienGiangDayGdtcQpDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienGiangDayGdtcQpDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienGiangDayGdtcQpDataSourceActionList

	/// <summary>
	/// Supports the GiangVienGiangDayGdtcQpDataSourceDesigner class.
	/// </summary>
	internal class GiangVienGiangDayGdtcQpDataSourceActionList : DesignerActionList
	{
		private GiangVienGiangDayGdtcQpDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienGiangDayGdtcQpDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienGiangDayGdtcQpDataSourceActionList(GiangVienGiangDayGdtcQpDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienGiangDayGdtcQpSelectMethod SelectMethod
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

	#endregion GiangVienGiangDayGdtcQpDataSourceActionList
	
	#endregion GiangVienGiangDayGdtcQpDataSourceDesigner
	
	#region GiangVienGiangDayGdtcQpSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienGiangDayGdtcQpDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienGiangDayGdtcQpSelectMethod
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
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy
	}
	
	#endregion GiangVienGiangDayGdtcQpSelectMethod

	#region GiangVienGiangDayGdtcQpFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienGiangDayGdtcQp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienGiangDayGdtcQpFilter : SqlFilter<GiangVienGiangDayGdtcQpColumn>
	{
	}
	
	#endregion GiangVienGiangDayGdtcQpFilter

	#region GiangVienGiangDayGdtcQpExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienGiangDayGdtcQp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienGiangDayGdtcQpExpressionBuilder : SqlExpressionBuilder<GiangVienGiangDayGdtcQpColumn>
	{
	}
	
	#endregion GiangVienGiangDayGdtcQpExpressionBuilder	

	#region GiangVienGiangDayGdtcQpProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienGiangDayGdtcQpChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienGiangDayGdtcQp"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienGiangDayGdtcQpProperty : ChildEntityProperty<GiangVienGiangDayGdtcQpChildEntityTypes>
	{
	}
	
	#endregion GiangVienGiangDayGdtcQpProperty
}

