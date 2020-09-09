using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TextureSetting : AssetPostprocessor
{
   public void OnPreprocessTexture()
   {
      TextureImporter importer = (TextureImporter) assetImporter;
      importer.textureType = TextureImporterType.Sprite;
   }
}
