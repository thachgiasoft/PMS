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
	/// Represents the DataRepository.GiangVienThayDoiHocHamProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienThayDoiHocHamDataSourceDesigner))]
	public class GiangVienThayDoiHocHamDataSource : ProviderDataSource<GiangVienThayDoiHocHam, GiangVienThayDoiHocHamKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocHamDataSource class.
		/// </summary>
		public GiangVienThayDoiHocHamDataSource() : base(new GiangVienThayDoiHocHamService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienThayDoiHocHamDataSourceView used by the GiangVienThayDoiHocHamDataSource.
		/// </summary>
		protected GiangVienThayDoiHocHamDataSourceView GiangVienThayDoiHocHamView
		{
			get { return ( View as GiangVienThayDoiHocHamDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienThayDoiHocHamDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienThayDoiHocHamSelectMethod SelectMethod
		{
			get
			{
				GiangVienThayDoiHocHamSelectMethod selectMethod = GiangVienThayDoiHocHamSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienThayDoiHocHamSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienThayDoiHocHamDataSourceView class that is to be
		/// used by the GiangVienThayDoiHocHamDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienThayDoiHocHamDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienThayDoiHocHam, GiangVienThayDoiHocHamKey> GetNewDataSourceView()
		{
			return new GiangVienThayDoiHocHamDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienThayDoiHocHamDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienThayDoiHocHamDataSourceView : ProviderDataSourceView<GiangVienThayDoiHocHam, GiangVienThayDoiHocHamKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocHamDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienThayDoiHocHamDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienThayDoiHocHamDataSourceView(GiangVienThayDoiHocHamDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienThayDoiHocHamDataSource GiangVienThayDoiHocHamOwner
		{
			get { return Owner as GiangVienThayDoiHocHamDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienThayDoiHocHamSelectMethod SelectMethod
		{
			get { return GiangVienThayDoiHocHamOwner.SelectMethod; }
			set { GiangVienThayDoiHocHamOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienThayDoiHocHamService GiangVienThayDoiHocHamProvider
		{
			get { return Provider as GiangVienThayDoiHocHamService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienThayDoiHocHam> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienThayDoiHocHam> results = null;
			GiangVienThayDoiHocHam item;
			count = 0;
			
			System.Int32 _maQuanLy;

			switch ( SelectMethod )
			{
				case GiangVienThayDoiHocHamSelectMethod.Get:
					GiangVienThayDoiHocHamKey entityKey  = new GiangVienThayDoiHocHamKey();
					entityKey.Load(values);
					item = GiangVienThayDoiHocHamProvider.Get(entityKey);
					results = new TList<GiangVienThayDoiHocHam>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienThayDoiHocHamSelectMethod.GetAll:
                    results = GiangVienThayDoiHocHamProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienThayDoiHocHamSelectMethod.GetPaged:
					results = GiangVienThayDoiHocHamProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienThayDoiHocHamSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienThayDoiHocHamProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienThayDoiHocHamProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienThayDoiHocHamSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.Int32)) : (int)0;
					item = GiangVienThayDoiHocHamProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<GiangVienThayDoiHocHam>();
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
			if ( SelectMethod == GiangVienThayDoiHocHamSelectMethod.Get || SelectMethod == GiangVienThayDoiHocHamSelectMethod.GetByMaQuanLy )
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
				GiangVienThayDoiHocHam entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienThayDoiHocHamProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienThayDoiHocHam> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienThayDoiHocHamProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienThayDoiHocHamDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienThayDoiHocHamDataSource class.
	/// </summary>
	public class GiangVienThayDoiHocHamDataSourceDesigner : ProviderDataSourceDesigner<GiangVienThayDoiHocHam, GiangVienThayDoiHocHamKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocHamDataSourceDesigner class.
		/// </summary>
		public GiangVienThayDoiHocHamDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienThayDoiHocHamSelectMethod SelectMethod
		{
			get { return ((GiangVienThayDoiHocHamDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienThayDoiHocHamDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienThayDoiHocHamDataSourceActionList

	/// <summary>
	/// Supports the GiangVienThayDoiHocHamDataSourceDesigner class.
	/// </summary>
	internal class GiangVienThayDoiHocHamDataSourceActionList : DesignerActionList
	{
		private GiangVienThayDoiHocHamDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienThayDoiHocHamDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienThayDoiHocHamDataSourceActionList(GiangVienThayDoiHocHamDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienThayDoiHocHamSelectMethod SelectMethod
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

	#endregion GiangVienThayDoiHocHamDataSourceActionList
	
	#endregion GiangVienThayDoiHocHamDataSourceDesigner
	
	#region GiangVienThayDoiHocHamSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienThayDoiHocHamDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienThayDoiHocHamSelectMethod
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
	
	#endregion GiangVienThayDoiHocHamSelectMethod

	#region GiangVienThayDoiHocHamFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiHocHam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiHocHamFilter : SqlFilter<GiangVienThayDoiHocHamColumn>
	{
	}
	
	#endregion GiangVienThayDoiHocHamFilter

	#region GiangVienThayDoiHocHamExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiHocHam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiHocHamExpressionBuilder : SqlExpressionBuilder<GiangVienThayDoiHocHamColumn>
	{
	}
	
	#endregion GiangVienThayDoiHocHamExpressionBuilder	

	#region GiangVienThayDoiHocHamProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienThayDoiHocHamChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienThayDoiHocHam"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienThayDoiHocHamProperty : ChildEntityProperty<GiangVienThayDoiHocHamChildEntityTypes>
	{
	}
	
	#endregion GiangVienThayDoiHocHamProperty
}

