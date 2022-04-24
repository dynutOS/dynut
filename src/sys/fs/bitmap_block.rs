use super::block::Block;
use super::super_block;
use super::super_block::SuperBlock;

use bit_field::BitField

pub const BITMAP_SIZE: usize = 8 * super::BLOCK_SIZE;

pub struct BitmapBlock {}

impl BitmapBlock {
    fn block_index(addr: u32) -> u32 {
        let sb = SuperBlock::read();
        let size = sb.block_size()
        let i = addr - sb.data_area();
        sb.bitmap_area() + (i / size / 8)
    }
}