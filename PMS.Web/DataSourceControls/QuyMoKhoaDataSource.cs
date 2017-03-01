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
	/// Represents the DataRepository.QuyMoKhoaProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(QuyMoKhoaDataSourceDesigner))]
	public class QuyMoKhoaDataSource : ProviderDataSource<QuyMoKhoa, QuyMoKhoaKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyMoKhoaDataSource class.
		/// </summary>
		public QuyMoKhoaDataSource() : base(new QuyMoKhoaService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the QuyMoKhoaDataSourceView used by the QuyMoKhoaDataSource.
		/// </summary>
		protected QuyMoKhoaDataSourceView QuyMoKhoaView
		{
			get { return ( View as QuyMoKhoaDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the QuyMoKhoaDataSource control invokes to retrieve data.
		/// </summary>
		public QuyMoKhoaSelectMethod SelectMethod
		{
			get
			{
				QuyMoKhoaSelectMethod selectMethod = QuyMoKhoaSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (QuyMoKhoaSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the QuyMoKhoaDataSourceView class that is to be
		/// used by the QuyMoKhoaDataSource.
		/// </summary>
		/// <returns>An instance of the QuyMoKhoaDataSourceView class.</returns>
		protected override BaseDataSourceView<QuyMoKhoa, QuyMoKhoaKey> GetNewDataSourceView()
		{
			return new QuyMoKhoaDataSourceView(this, DefaultViewName);
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
	/// Supports the QuyMoKhoaDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class QuyMoKhoaDataSourceView : ProviderDataSourceView<QuyMoKhoa, QuyMoKhoaKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyMoKhoaDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the QuyMoKhoaDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public QuyMoKhoaDataSourceView(QuyMoKhoaDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal QuyMoKhoaDataSource QuyMoKhoaOwner
		{
			get { return Owner as QuyMoKhoaDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal QuyMoKhoaSelectMethod SelectMethod
		{
			get { return QuyMoKhoaOwner.SelectMethod; }
			set { QuyMoKhoaOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal QuyMoKhoaService QuyMoKhoaProvider
		{
			get { return Provider as QuyMoKhoaService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<QuyMoKhoa> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<QuyMoKhoa> results = null;
			QuyMoKhoa item;
			count = 0;
			
			System.String _maKhoa;
			System.Int32? _idQuyMo_nullable;

			switch ( SelectMethod )
			{
				case QuyMoKhoaSelectMethod.Get:
					QuyMoKhoaKey entityKey  = new QuyMoKhoaKey();
					entityKey.Load(values);
					item = QuyMoKhoaProvider.Get(entityKey);
					results = new TList<QuyMoKhoa>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case QuyMoKhoaSelectMethod.GetAll:
                    results = QuyMoKhoaProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case QuyMoKhoaSelectMethod.GetPaged:
					results = QuyMoKhoaProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case QuyMoKhoaSelectMethod.Find:
					if ( FilterParameters != null )
						results = QuyMoKhoaProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = QuyMoKhoaProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case QuyMoKhoaSelectMethod.GetByMaKhoa:
					_maKhoa = ( values["MaKhoa"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaKhoa"], typeof(System.String)) : string.Empty;
					item = QuyMoKhoaProvider.GetByMaKhoa(_maKhoa);
					results = new TList<QuyMoKhoa>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case QuyMoKhoaSelectMethod.GetByIdQuyMo:
					_idQuyMo_nullable = (System.Int32?) EntityUtil.ChangeType(values["IdQuyMo"], typeof(System.Int32?));
					results = QuyMoKhoaProvider.GetByIdQuyMo(_idQuyMo_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case QuyMoKhoaSelectMethod.GetQuyMoKhoa:
					results = QuyMoKhoaProvider.GetQuyMoKhoa(StartIndex, PageSize);
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
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == QuyMoKhoaSelectMethod.Get || SelectMethod == QuyMoKhoaSelectMethod.GetByMaKhoa )
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
				QuyMoKhoa entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					QuyMoKhoaProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<QuyMoKhoa> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			QuyMoKhoaProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region QuyMoKhoaDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the QuyMoKhoaDataSource class.
	/// </summary>
	public class QuyMoKhoaDataSourceDesigner : ProviderDataSourceDesigner<QuyMoKhoa, QuyMoKhoaKey>
	{
		/// <summary>
		/// Initializes a new instance of the QuyMoKhoaDataSourceDesigner class.
		/// </summary>
		public QuyMoKhoaDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuyMoKhoaSelectMethod SelectMethod
		{
			get { return ((QuyMoKhoaDataSource) DataSource).SelectMethod; }
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
				actions.Add(new QuyMoKhoaDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region QuyMoKhoaDataSourceActionList

	/// <summary>
	/// Supports the QuyMoKhoaDataSourceDesigner class.
	/// </summary>
	internal class QuyMoKhoaDataSourceActionList : DesignerActionList
	{
		private QuyMoKhoaDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the QuyMoKhoaDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public QuyMoKhoaDataSourceActionList(QuyMoKhoaDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuyMoKhoaSelectMethod SelectMethod
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

	#endregion QuyMoKhoaDataSourceActionList
	
	#endregion QuyMoKhoaDataSourceDesigner
	
	#region QuyMoKhoaSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the QuyMoKhoaDataSource.SelectMethod property.
	/// </summary>
	public enum QuyMoKhoaSelectMethod
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
		/// Represents the GetByMaKhoa method.
		/// </summary>
		GetByMaKhoa,
		/// <summary>
		/// Represents the GetByIdQuyMo method.
		/// </summary>
		GetByIdQuyMo,
		/// <summary>
		/// Represents the GetQuyMoKhoa method.
		/// </summary>
		GetQuyMoKhoa
	}
	
	#endregion QuyMoKhoaSelectMethod

	#region QuyMoKhoaFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyMoKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyMoKhoaFilter : SqlFilter<QuyMoKhoaColumn>
	{
	}
	
	#endregion QuyMoKhoaFilter

	#region QuyMoKhoaExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyMoKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyMoKhoaExpressionBuilder : SqlExpressionBuilder<QuyMoKhoaColumn>
	{
	}
	
	#endregion QuyMoKhoaExpressionBuilder	

	#region QuyMoKhoaProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;QuyMoKhoaChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="QuyMoKhoa"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyMoKhoaProperty : ChildEntityProperty<QuyMoKhoaChildEntityTypes>
	{
	}
	
	#endregion QuyMoKhoaProperty
}

