/**
 * @filename: font.rs
 * @author: Krisna Pranav
 * @license: MIT Copyright (c) 2022 dynutOS, Krisna Pranav
 */

#[derive(Debug)]
pub struct SuperBlock {
    signature: &'static [u8; 8],
    version: u8,
    block_size: u32,
    pub block_count: u32,
    pub alloc_count: u32,
}

impl SuperBlock {
    pub fn check_ata(bus: u8, dsk: u8) -> bool {
        let mut buf = [0u8; super::BLOCK_SIZE];
        if sys::ata::read(bus, dsk, SUPERBLOCK_ADDR, &mut buf).is_err() {
            return false;
        }
        &buf[0..8] == SIGNATURE
    }
}
